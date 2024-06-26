use master;
CREATE DATABASE BIBLIO_DB
GO
USE BIBLIO_DB
/*==============================================================*/
/* Table : ETUDIANT                                             */
/*==============================================================*/

create table ETUDIANT 
(
   ID_ETUDIANT          integer                        not null,
   NOMETUDIANT          varchar(255)                   null,
   PRENOMETUDIANT       varchar(255)                  null,
   EMAILETUDIANT        varchar(255)                   null,
   PASSWORDETUDIANT     varchar(255)                   null,
   constraint PK_ETUDIANT primary key (ID_ETUDIANT)
);

/*==============================================================*/
/* Table : LIVRE                                                */
/*==============================================================*/
create table LIVRE 
(
   ID_LIVRE             integer                        not null,
   TITRELIVRE           text                   null,
   QTELIVRE             integer                        null,
   NOM_AUTEUR           text                   null,
   ETAT_LIVRE           text                   null,
   CATEGORIE            text                   null,
   constraint PK_LIVRE primary key (ID_LIVRE)
);
go
/*==============================================================*/
/* Table : RESERVATION                                          */
/*==============================================================*/
create table RESERVATION 
(
   ID_RESERVATION       integer                        not null,
   ID_RESPONSABLE       integer                        not null,
   ID_ETUDIANT          integer                        not null,
   DATERESERVATION      date                      null,
   DATEDELAIS           date                      null,
   DATEREMUE            date                      null,
   STAUTRESERVATION     varchar(255)                   null,
   ID_LIVRE             integer                        not null,
   constraint PK_RESERVATION primary key (ID_RESERVATION)
);
go

/*==============================================================*/
/* Table : RESPONSABLE                                          */
/*==============================================================*/
create table RESPONSABLE 
(
   ID_RESPONSABLE       integer                        not null,
   LOGINRESPONSABLE     text                   null,
   PASSWORDRESPONSABLE  text                   null,
   constraint PK_RESPONSABLE primary key (ID_RESPONSABLE)
);
go
alter table RESERVATION
   add constraint FK_RESERVAT_FAIRE_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT)
      on update no action
      on delete no action;
go	  
alter table RESERVATION
   add constraint FK_RESERVAT_GERER_RESPONSA foreign key (ID_RESPONSABLE)
      references RESPONSABLE (ID_RESPONSABLE)
      on update no action
      on delete no action;
go

go
alter table RESERVATION
   add constraint FK_RESERVER_RESERVER2_LIVRE foreign key (ID_LIVRE)
      references LIVRE (ID_LIVRE)
      on update no action
      on delete no action;

select * from RESPONSABLE