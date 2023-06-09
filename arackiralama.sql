USE [master]
GO
/****** Object:  Database [projem]    Script Date: 3.06.2023 00:57:41 ******/
CREATE DATABASE [projem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'projem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\projem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'projem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\projem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [projem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [projem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [projem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [projem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [projem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [projem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [projem] SET ARITHABORT OFF 
GO
ALTER DATABASE [projem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [projem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [projem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [projem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [projem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [projem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [projem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [projem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [projem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [projem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [projem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [projem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [projem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [projem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [projem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [projem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [projem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [projem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [projem] SET  MULTI_USER 
GO
ALTER DATABASE [projem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [projem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [projem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [projem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [projem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [projem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [projem] SET QUERY_STORE = OFF
GO
USE [projem]
GO
/****** Object:  Table [dbo].[arac]    Script Date: 3.06.2023 00:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac](
	[plaka] [nvarchar](50) NULL,
	[marka] [nvarchar](50) NULL,
	[seriveyıl] [nvarchar](50) NULL,
	[renk] [nvarchar](50) NULL,
	[km] [nvarchar](50) NULL,
	[yakıt] [nvarchar](50) NULL,
	[kiraücreti] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[girişform]    Script Date: 3.06.2023 00:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[girişform](
	[tc] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MÜSTERİBİLGİ]    Script Date: 3.06.2023 00:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MÜSTERİBİLGİ](
	[tc] [nvarchar](50) NULL,
	[adsoyad] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[adres] [nvarchar](50) NULL,
	[mail] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'34 SZ 696', N'BMW', N'320D 2012', N'MAVİ', N'198000', N'BENZİN+LPG', N'500')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'31 ABD 19', N'Ford', N'CONNECT 2009', N'BEJ ', N'156000', N'BENZİN', N'300')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'34 ENG 58', N'Nissan', N'QASHQAİ 2014', N'BEYAZ', N'155000', N'BENZİN', N'355')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'49 SK 972', N'Ford', N'RANGER 2022', N'MAVİ', N'7000', N'BENZİN', N'500')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'31 FB 767', N'Mercedes-Benz', N'C180 2015', N'SİYAH', N'36000', N'DİZEL', N'400')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'72 AKL 17', N'Cadillac', N'ESCALADE 2017', N'GRİ', N'52000', N'BENZİN', N'800')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'44 MLT 44', N'Honda', N'CRV  2016', N'BEYAZ', N'78000', N'BENZİN+LPG', N'450')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'31 SE 141', N'Ford', N'TRANSİT 2004', N'BEYAZ', N'270000', N'DİZEL', N'200')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'31 DN 819', N'Fiat', N'DOBLO 2006', N'GRİ', N'301000', N'DİZEL', N'200')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'06 SY 174', N'Hyundai', N'SANTAFE 2010', N'SİYAH', N'170000', N'BENZİN+LPG', N'500')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'35 MKA 38', N'Honda', N'CİVİC 2009', N'SİYAH', N'145000', N'BENZİN+LPG', N'400')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'18 B 4050', N'Opel', N'ASTRA 2016', N'MAVİ', N'93000', N'BENZİN', N'300')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'34 SC 756', N'FİAT', N'EGEA 2021', N'BEYAZ', N'60500', N'DİZEL', N'200')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'01 SA 071', N'Dacia', N'SANDERO 2014', N'KIRMIZI', N'98600', N'BENZİN+LPG', N'200')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'31 SY 522', N'Rolls Royce', N'GHOST 2015', N'SİYAH', N'18000', N'BENZİN', N'2500')
INSERT [dbo].[arac] ([plaka], [marka], [seriveyıl], [renk], [km], [yakıt], [kiraücreti]) VALUES (N'31 SV 313', N'Skoda', N'FABİA 2017', N'BEYAZ', N'52000', N'BENZİN+LPG', N'300')
GO
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'12345678901', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'12345612345', N'e35cf7b66449df565f93c607d5a81d09')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'27864321123', N'14ff0d939ef63df4d9d36bdf7bc8672a')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'38872423962', N'90d7a1c6fa608dba5fed01230c65fcdf')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'123', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'1234', N'81dc9bdb52d04dc20036dbd8313ed055')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'iste', N'ce1d0772614555bf622b408604a326bf')
INSERT [dbo].[girişform] ([tc], [sifre]) VALUES (N'ıd', N'8cdee5526476b101869401a37c03e379')
GO
INSERT [dbo].[MÜSTERİBİLGİ] ([tc], [adsoyad], [telefon], [adres], [mail]) VALUES (N'2323456778', N'ALİ SAMET CENNET', N'053841756451111', N'Sakarya İskenderun /Hatay', N'asametcennet@gmail.com')
INSERT [dbo].[MÜSTERİBİLGİ] ([tc], [adsoyad], [telefon], [adres], [mail]) VALUES (N'12345678911', N'AHMET YILMAZ', N'05434323265', N'ANKARA yenimahalle', N'ahmetyılmaz@gmail.com')
INSERT [dbo].[MÜSTERİBİLGİ] ([tc], [adsoyad], [telefon], [adres], [mail]) VALUES (N'38875423611', N'MEHMET KAYA', N'05454523256', N'Ankara/Türkiye', N'mkaya06@gmail.com')
GO
USE [master]
GO
ALTER DATABASE [projem] SET  READ_WRITE 
GO
