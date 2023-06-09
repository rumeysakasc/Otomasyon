USE [master]
GO
/****** Object:  Database [KutuphaneOto]    Script Date: 30.04.2023 15:32:27 ******/
CREATE DATABASE [KutuphaneOto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KutuphaneOto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KutuphaneOto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KutuphaneOto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KutuphaneOto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [KutuphaneOto] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KutuphaneOto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KutuphaneOto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KutuphaneOto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KutuphaneOto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KutuphaneOto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KutuphaneOto] SET ARITHABORT OFF 
GO
ALTER DATABASE [KutuphaneOto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KutuphaneOto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KutuphaneOto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KutuphaneOto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KutuphaneOto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KutuphaneOto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KutuphaneOto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KutuphaneOto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KutuphaneOto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KutuphaneOto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KutuphaneOto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KutuphaneOto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KutuphaneOto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KutuphaneOto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KutuphaneOto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KutuphaneOto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KutuphaneOto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KutuphaneOto] SET RECOVERY FULL 
GO
ALTER DATABASE [KutuphaneOto] SET  MULTI_USER 
GO
ALTER DATABASE [KutuphaneOto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KutuphaneOto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KutuphaneOto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KutuphaneOto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KutuphaneOto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KutuphaneOto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'KutuphaneOto', N'ON'
GO
ALTER DATABASE [KutuphaneOto] SET QUERY_STORE = OFF
GO
USE [KutuphaneOto]
GO
/****** Object:  Table [dbo].[kayit]    Script Date: 30.04.2023 15:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kayit](
	[kayit_no] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](11) NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[tel] [nvarchar](50) NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[adres] [nvarchar](50) NULL,
	[foto] [nvarchar](100) NULL,
 CONSTRAINT [PK_kayit] PRIMARY KEY CLUSTERED 
(
	[kayit_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kitapAra]    Script Date: 30.04.2023 15:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitapAra](
	[barkod_no] [int] IDENTITY(1,1) NOT NULL,
	[kitap_adi] [nvarchar](50) NULL,
	[kitap_yazari] [nvarchar](50) NULL,
	[yayin_evi] [nvarchar](50) NULL,
	[kitap_turu] [nvarchar](50) NULL,
 CONSTRAINT [PK_kitapAra] PRIMARY KEY CLUSTERED 
(
	[barkod_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kitapListele]    Script Date: 30.04.2023 15:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitapListele](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kitap_adi] [nvarchar](50) NULL,
	[kitap_yazari] [nvarchar](50) NULL,
	[kitap_turu] [nvarchar](50) NULL,
	[yayin_evi] [nvarchar](50) NULL,
	[baski_yili] [int] NULL,
	[sayfa_sayisi] [int] NULL,
	[nerede] [nvarchar](50) NULL,
 CONSTRAINT [PK_kitapListele_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Listeleme]    Script Date: 30.04.2023 15:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Listeleme](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kitap_adi] [varchar](max) NULL,
	[kitap_yazari] [nvarchar](50) NULL,
	[kitap_turu] [nvarchar](50) NULL,
	[yayin_evi] [nvarchar](50) NULL,
	[sayfa_sayisi] [nvarchar](50) NULL,
	[aciklama] [nvarchar](50) NULL,
	[nerede] [nvarchar](50) NULL,
 CONSTRAINT [PK_Listeleme] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[new_kayit]    Script Date: 30.04.2023 15:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[new_kayit](
	[kayit_no] [int] NULL,
	[tc] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyAd] [nvarchar](50) NULL,
	[tel] [int] NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[adres] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personel]    Script Date: 30.04.2023 15:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel](
	[personel_id] [int] IDENTITY(1,1) NOT NULL,
	[personel_ad] [nvarchar](50) NULL,
	[personel_soyad] [nvarchar](50) NULL,
	[personel_tc] [nvarchar](11) NULL,
	[personel_tel] [nchar](10) NULL,
	[personel_mail] [nvarchar](50) NULL,
	[personel_kAdi] [nvarchar](50) NULL,
	[personel_sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_personel] PRIMARY KEY CLUSTERED 
(
	[personel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kayit] ON 

INSERT [dbo].[kayit] ([kayit_no], [tc], [ad], [soyad], [tel], [kullanici_adi], [sifre], [adres], [foto]) VALUES (39, N'11111111112', N'ali', N'pınar', N'1111111111', N'a', N'1', N'', N'C:\Users\rumey\OneDrive\Masaüstü\about.jpg')
INSERT [dbo].[kayit] ([kayit_no], [tc], [ad], [soyad], [tel], [kullanici_adi], [sifre], [adres], [foto]) VALUES (40, N'11111111111', N'kader', N'aydın', N'1111111111', N'kader', N'123', N'', N'C:\Users\rumey\OneDrive\Masaüstü\5D4AA253-0C18-40E3-AB09-426F691BEF62.jpeg')
INSERT [dbo].[kayit] ([kayit_no], [tc], [ad], [soyad], [tel], [kullanici_adi], [sifre], [adres], [foto]) VALUES (41, N'11111111113', N'ali', N'pınar', N'1111111111', N'a', N'1', N'', N'C:\Users\rumey\OneDrive\Masaüstü\image\lbrs.jpg')
INSERT [dbo].[kayit] ([kayit_no], [tc], [ad], [soyad], [tel], [kullanici_adi], [sifre], [adres], [foto]) VALUES (67, N'12345678906', N'fgh', N'', N'1234567890', N'sdffghjdfgh', N'sdfghjdfg', N'dfghj', N'C:\Users\rumey\OneDrive\Masaüstü\image\books.png')
SET IDENTITY_INSERT [dbo].[kayit] OFF
GO
SET IDENTITY_INSERT [dbo].[kitapAra] ON 

INSERT [dbo].[kitapAra] ([barkod_no], [kitap_adi], [kitap_yazari], [yayin_evi], [kitap_turu]) VALUES (1, N'İçimizdeki Şeytan', N'Sabahattin Ali', N'Yapı Kredi Yayınları', N'Roman')
INSERT [dbo].[kitapAra] ([barkod_no], [kitap_adi], [kitap_yazari], [yayin_evi], [kitap_turu]) VALUES (2, N'İçimizdeki Şeytan', N'Sabahattin Ali', N'İş Bankası Yayınları', N'Roman')
INSERT [dbo].[kitapAra] ([barkod_no], [kitap_adi], [kitap_yazari], [yayin_evi], [kitap_turu]) VALUES (3, N'İnsan İnsana', N'DoğanCüceloğlu', N'Kronik Yayın Evi', N'Psikoloji')
SET IDENTITY_INSERT [dbo].[kitapAra] OFF
GO
SET IDENTITY_INSERT [dbo].[kitapListele] ON 

INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (6, N'insan insana', N'Doğan Cüceloğlu', N'psikoloji', N'kronik', 2019, 320, N'Okuyucu')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (13, N'İçimizdeki Şeytan', N'Sabahattin Ali', N'Roman', N'Yapı kredi', 2008, 225, N'Raf')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (15, N'İnsanlığımı Yitirirken', N'Osamu Dazai', N'Roman', N'İTHAKİ YAYINLARI', 2010, 128, N'Raf')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (16, N'Kuru Kız', N'Ayfer Tunç', N'Roman', N'CAN YAYINLARI', 2022, 216, N'Raf')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (17, N'Simyacı', N'Paulo Coelho', N'Roman', N'CAN YAYINLARI', 2005, 184, N'')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (18, N'Geliştiren Anne-Baba
', N'Doğan Cüceloğlu', N'Psikoloji', N'KRONİK KİTAP', 2021, 192, N'Raf')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (19, N'Şeker Protakalı', N'Jose Mauro De Vasconcelos', N'Edebi Roman', N'CAN YAYINLARI', 2000, 182, N'Okuyucu')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (20, N'Veronika Ölmek İstiyor
', N'Paulo Coelho', N'Roman', N'CAN YAYINLARI', 2005, 198, N'Raf')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (21, N'Zeytindağı', N'Falih Rıfkı Atay ', N'Roman', N' POZİTİF YAYINLARI', 2013, 176, N'Okuyucu')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (22, N'Bir Başka Din: Tasavvuf
', N'Cemre Demirel', N'Tasavvufi', N'İSTANBUL YAYINEVİ', 2019, 320, N'Okuyucu')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (23, N'Asr-ı Saadet Atlası', N'Merve Safa Likoğlu', N'Çocuk Kitabı', N'HÜDHÜD KİTAP
', 2023, 36, N'Raf')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (24, N'Kürk Mantolu Madonna
', N'Sabahattin Ali', N'Roman', N'YAPI KREDİ YAYINLARI', 2005, 160, N'Okuyucu')
INSERT [dbo].[kitapListele] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [baski_yili], [sayfa_sayisi], [nerede]) VALUES (25, N'İçimizdeki Şeytan', N'Sabahattin Ali', N'Roman', N'İŞ BANKASI YAYINLARI', 2010, 225, N'Raf')
SET IDENTITY_INSERT [dbo].[kitapListele] OFF
GO
SET IDENTITY_INSERT [dbo].[Listeleme] ON 

INSERT [dbo].[Listeleme] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [sayfa_sayisi], [aciklama], [nerede]) VALUES (1, N'içimizdeki şeytan', N'sabahattin ali', N'roman', N'ışık yayınları', N'185', N'yok', N'Raf')
INSERT [dbo].[Listeleme] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [sayfa_sayisi], [aciklama], [nerede]) VALUES (3, N'Uçurtma Avcısı', N'Khaled Hosseini
', N'Drama', N'Alçı Yayınları', N'215', N'drama-psikoloji-roman', N'Okuyucu')
INSERT [dbo].[Listeleme] ([id], [kitap_adi], [kitap_yazari], [kitap_turu], [yayin_evi], [sayfa_sayisi], [aciklama], [nerede]) VALUES (4, N'İnsan İnsana', N'Doğan Cüceloğlu', N'Psikoloji', N'Kronik Yayınları', N'365', NULL, N'Raf')
SET IDENTITY_INSERT [dbo].[Listeleme] OFF
GO
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (1, N'', N'jhgfd', N'hgfd', 1234567890, N'hgfd', N'hgfds', N'jhgf')
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (NULL, N'12341234123333', N'jhgfd', N'hgfd', 1234567890, N'hgfd', N'hgfds', N'jhgf')
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (NULL, N'', N'', N'', 0, N'', N'', N'')
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (NULL, N'8765432154', N'mehmet', N'gül', 1234561234, N'123', N'merve sk no:10', N'mehm.gul')
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (NULL, N'11111111111', N'ali', N'mert', 0, N'12345', N'sultan sk no:5', N'ali1')
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (NULL, N'1234256789', N'mehmet', N'all', 1234561234, N'123', N'merve sk no:10', N'mehm.gul')
INSERT [dbo].[new_kayit] ([kayit_no], [tc], [ad], [soyAd], [tel], [kullanici_adi], [sifre], [adres]) VALUES (NULL, N'123456785', N'kjhgfd', N'gfd', 1234561234, N'jhgfd', N'jhgfd', N'jhgfd')
GO
SET IDENTITY_INSERT [dbo].[personel] ON 

INSERT [dbo].[personel] ([personel_id], [personel_ad], [personel_soyad], [personel_tc], [personel_tel], [personel_mail], [personel_kAdi], [personel_sifre]) VALUES (1, N'Güven', N'Aydın', N'11111111111', N'1234567891', N'g.aydin@gmail.com', N'guven.aydin', N'guven1528')
INSERT [dbo].[personel] ([personel_id], [personel_ad], [personel_soyad], [personel_tc], [personel_tel], [personel_mail], [personel_kAdi], [personel_sifre]) VALUES (2, N'ayşe', N'güleryüz', N'12111111111', N'1222355478', N'ayse22@gmail.cım', N'ayse1', N'1234')
INSERT [dbo].[personel] ([personel_id], [personel_ad], [personel_soyad], [personel_tc], [personel_tel], [personel_mail], [personel_kAdi], [personel_sifre]) VALUES (3, N'ela', N'susuz', N'12342221111', N'1122112211', N'susuzlar.ben@gmail.com', N'elasu', N'ela25')
SET IDENTITY_INSERT [dbo].[personel] OFF
GO
USE [master]
GO
ALTER DATABASE [KutuphaneOto] SET  READ_WRITE 
GO
