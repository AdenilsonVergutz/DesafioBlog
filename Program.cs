using DesafioBlog.Formulario;
using DesafioBlog.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Collections.Generic;
using System;

namespace DesafioBlog
{
    internal static class Program
    {

        private const string CONNECTION_STRING = @"Server=ADENILSON-PC\SQL2022;Database=Blog;user ID=sa;Password=saroot; TrustServerCertificate=True";

        [STAThread]
        static void Main()
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();
        }
        //ApplicationConfiguration.Initialize();
        //Application.Run(new frmTelaPrincipal());
        public static void Load()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmTelaPrincipal());

            //Database.Connection.Close();

        }
    }
}






//Script para criar banco



//CREATE DATABASE[Blog]
//GO

//USE[Blog]
//GO

//CREATE TABLE[Perfil] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [Nome] VARCHAR(80) NOT NULL,

//    CONSTRAINT[PK_Perfil] PRIMARY KEY([Id], [Nome])
	
//	)

//CREATE TABLE[Usuario] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [Nome] NVARCHAR(80) NOT NULL,
//    [Email] VARCHAR(200) NOT NULL,
//    [Senha] VARCHAR(255) NOT NULL,
//    [RepitaSenha] VARCHAR(255) NOT NULL,
//    [Bio] TEXT NOT NULL,
//    [Slug] VARCHAR(80) NOT NULL,
//    [PerfilId] INT NOT NULL,
//    [PerfilName] VARCHAR(80) NULL,

//    CONSTRAINT[PK_User] PRIMARY KEY([Id]),
//    CONSTRAINT[UQ_User_Email] UNIQUE([Email]),
//    CONSTRAINT[UQ_User_Slug] UNIQUE([Slug]),
//	CONSTRAINT[FK_UserPerfil] FOREIGN KEY([PerfilId], [PerfilName]) REFERENCES[Perfil]([Id], [Nome]),

//)
//CREATE NONCLUSTERED INDEX [IX_User_Email] ON[Usuario]([Email])
//CREATE NONCLUSTERED INDEX [IX_User_Slug] ON[Usuario]([Slug])


//CREATE TABLE[Categoria] (
//    [Id] INT NOT NULL IDENTITY(1, 1),
//    [Nome] VARCHAR(80) NOT NULL,

//    CONSTRAINT[PK_Category] PRIMARY KEY([Id]),
//)


//CREATE TABLE[Tag] (
//     [Id] INT NOT NULL IDENTITY(1, 1),
//     [Nome] VARCHAR(80) NOT NULL,

//     CONSTRAINT[PK_Tag] PRIMARY KEY([Id]),
//     CONSTRAINT[UQ_TagNome] UNIQUE([Nome]),
//)


//CREATE TABLE[Post] (
//     [Id] INT NOT NULL IDENTITY(1, 1),
//     [CategoriaId] INT NOT NULL,
//     [AuthorId] INT NOT NULL,
//     [Titulo] VARCHAR(160) NOT NULL,
//     [Summary] VARCHAR(255) NOT NULL,
//     [Slug] VARCHAR(80) NOT NULL,
//     [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
//     [LastUpdateDate] DATETIME NULL DEFAULT(GETDATE()),
//     [TagId] INT NOT NULL,
//     [TagNome] VARCHAR(80) NOT NULL,

//     CONSTRAINT[PK_Post] PRIMARY KEY([Id]),
//     CONSTRAINT[FK_Post_Category] FOREIGN KEY([CategoriaId]) REFERENCES[Categoria]([Id]),
//     CONSTRAINT[FK_Post_Author] FOREIGN KEY([AuthorId]) REFERENCES[Usuario]([Id]),
//     CONSTRAINT[FK_Post_Tag] FOREIGN KEY([TagId]) REFERENCES[Tag]([Id]),
//     CONSTRAINT[FK_Post_TagName] FOREIGN KEY([TagNome]) REFERENCES[Tag]([Nome]),
//     CONSTRAINT[UQ_Post_Slug] UNIQUE([Slug])
// )
//CREATE NONCLUSTERED INDEX [IX_Post_Slug] ON[Post]([Slug])







//INSERT INTO[Usuario] VALUES (
//            'Adenilson Vergutz',
//            'Adenilson@mhtec.com.br',
//            'HASH',
//            '8X Microsoft MVP',
//            'https://',
//            'Andre-baltieri',
//			1,
//			'Autor')

//INSERT INTO[Perfil] VALUES (
//            'Autor',
//            'author')


//INSERT INTO[Tag] VALUES (
//            'ASP.NET',
//            'ASPNET')
