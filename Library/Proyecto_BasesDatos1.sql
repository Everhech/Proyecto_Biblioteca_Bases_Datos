---------------------------Proyect Bases Datos 1--------------------------------------
--------------------------------------------------------------------------------------

create table biblioteca(
    nitBiblioteca number(38) NOT NULL,
    nomBiblioteca varchar2(30) NOT NULL,
    constraint pk_biblioteca primary key (nitBiblioteca),
    constraint ckc_nitBiblioteca check (nitBiblioteca > 0)
);

create table libro(
    libCodigo number(38) NOT NULL,
    libTitulo varchar2(30) NOT NULL,
    numPaginas number(5) NOT NULL,
    libCategoria varchar2(20) NOT NULL,
    fechaInicioRegistro timestamp NOT NULL,
    fechaFinRegistro timestamp NOT NULL,
    nitBiblioteca number(38) NOT NULL,
    constraint pk_libro primary key (libCodigo),
    constraint fk_bibliotecaLibro foreign key (nitBiblioteca) references biblioteca(nitBiblioteca),
    constraint ckc_libCategoria check (libCategoria in ('Drama', 'Suspenso', 'Aventura')),
    constraint ckc_libCodigo check (libCodigo > 0)
);


create table registerLibroBiblioteca(
    libcodigo number(38) NOT NULL,
    nitBiblioteca number(38) NOT NULL,
    fechaInicioRegistro timestamp NOT NULL,
    fechaFinRegistro timestamp NOT NULL,
    constraint uq_libroBibliotecaRegister unique(libcodigo, nitBiblioteca, fechaInicioRegistro, fechaFinRegistro),
    constraint fk_libroBibliotecaLib foreign key (libcodigo) references libro(libcodigo),
    constraint fk_bibliotecaLibroBib foreign key (nitbiblioteca) references biblioteca(nitbiblioteca)
);
--------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------- PRUEBAS -------------------------------------------------------------------------------------------
-- Ingresa tupla a la tabla Biblioteca
insert into biblioteca(nitBiblioteca, nomBiblioteca) values (10,'Helgein');

-- Ingresa tupla a la tabla Libro  pruebas
insert into libro(libcodigo,libtitulo,numpaginas,libcategoria,fechainicioregistro,fechafinregistro,nitbiblioteca) values (600,'Don Quijote',2000,'Aventura',to_date('03/12/1990 06:24:02','mm-dd-yyyy HH24:MI:SS'),to_date('05/10/2023 20:16:05', 'mm-dd-yyyy HH24:MI:SS'),20);
insert into libro(libcodigo,libtitulo,numpaginas,libcategoria,fechainicioregistro,fechafinregistro,nitbiblioteca) values (200,'El viejo y el mar',1000,'Drama',to_date('03-12-1990 08:24:02','mm-dd-yyyy HH24:MI:SS'),to_date('08-05-2020 20:16:05', 'mm-dd-yyyy HH24:MI:SS'),10);
insert into libro(libcodigo,libtitulo,numpaginas,libcategoria,fechainicioregistro,fechafinregistro,nitbiblioteca) values (300,'El gato negro',200,'Drama',to_date('08-09-1991 07:24:02','mm-dd-yyyy HH24:MI:SS'),to_date('06-10-2023 20:16:05', 'mm-dd-yyyy HH24:MI:SS'),10);
insert into libro(libcodigo,libtitulo,numpaginas,libcategoria,fechainicioregistro,fechafinregistro,nitbiblioteca) values (400,'Davinci',200,'Suspenso',to_date('1/29/2023 07:24','mm-dd-yyyy HH24:MI:SS'),to_date('2/10/2023 20:16', 'mm-dd-yyyy HH24:MI:SS'),20);

-- Ingresar datos a libro - biblioteca (registro)
insert into registerlibrobiblioteca values (100, 10, to_date('03-12-1990 08:24:02','mm-dd-yyyy HH24:MI:SS'), to_date('08-05-2020 20:16:05', 'mm-dd-yyyy HH24:MI:SS'));
insert into registerlibrobiblioteca values (100, 20, to_date('05-10-1993 08:24:02','mm-dd-yyyy HH24:MI:SS'), to_date('10-06-2023 20:16:05', 'mm-dd-yyyy HH24:MI:SS'));

--muestra todos los libros registrados en biblioteca
select libcodigo, nitbiblioteca, fechainicioregistro, fechafinregistro from registerlibrobiblioteca;

--validación de codigo en libro-biblioteca
select libcodigo from registerlibrobiblioteca where libcodigo = 100;
select * from registerlibrobiblioteca where nitbiblioteca = 10 and libcodigo = 100;

--insert into libro values (300,'El gato negro',200,'Drama',to_date('08-09-1991 07:24:02','mm-dd-yyyy HH24:MI:SS'),to_date('06-10-2023 20:16:05', 'mm-dd-yyyy HH24:MI:SS'), null);
-- selecciona el titulo del libro y su categoria
select libtitulo,libcategoria from libro where libcategoria = 'Drama';

-- selecciona la categoria y cuenta la cantidad de cada categoria
select libcategoria, count(libcategoria) "Cantidad" from libro where libcategoria = 'Aventura' group by libcategoria;

-- muestra solo la cantidad de libros que hay de la categoria consultada
select count(libcategoria) "Cantidad" from libro where libcategoria = 'Aventura';


-- selecciona el nit de la libreria junto con la fecha de inicio de registro
select biblioteca.nomBiblioteca, libcodigo, libtitulo, libcategoria, fechafinregistro from libro inner join biblioteca on libro.nitbiblioteca = biblioteca.nitbiblioteca where biblioteca.nitbiblioteca = 10 and fechainicioregistro between to_date('1/29/2023 00:00:00','mm-dd-yyyy HH24:MI:SS') and to_date('1/29/2023 23:59:59','mm-dd-yyyy HH24:MI:SS'); 

-- muestra todos las bibliotecas y sus nombres
select nitbiblioteca, nombiblioteca from biblioteca;

-- muestra todos los libros que hay
select libcodigo, libtitulo, nitbiblioteca from libro;

-- Validación sobre el codigo del libro
select libcodigo from libro where libcodigo = 10;

-- Validación sobre el codigo de la biblioteca
select nitbiblioteca from biblioteca where nitbiblioteca = 30;

-- Validación sobre el nombre del libro (repetido o no)
select libtitulo from libro where UPPER(libtitulo) = UPPER('BAroN rOjo');

-- Validación sobre el nombre de la biblioteca (repetido o no)
select nombiblioteca from biblioteca where UPPER(nombiblioteca) = UPPER('howarD');
