create database skolniKurzy;
use skolniKurzy;


create table ucitel(
id int primary key identity(1,1),
jmeno varchar(20) not null,
prijmeni varchar(20) not null,
datum_narozeni varchar(20)
);

create table kurz(
id int primary key identity(1,1),
ucitel_id int foreign key references ucitel(id),
nazev varchar(20) not null,
);

create table student(
id int primary key identity(1,1),
jmeno varchar(20) not null,
prijmeni varchar(20) not null,
);

create table zapis_kurzu(
id int primary key identity(1,1),
kurz_id int foreign key references kurz(id),
student_id int foreign key references student(id),
datum_konani varchar(20) not null,
cena_kurzu int not null,
);

