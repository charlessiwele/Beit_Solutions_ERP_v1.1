USE [Beit_Solutions_WF]
GO
/****** Object:  Table [dbo].[Benefits]    Script Date: 28-Apr-19 4:52:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benefits](
	[BenefitId] [nvarchar](50) NULL,
	[BenefitName] [nvarchar](50) NULL,
	[Deductable] [nvarchar](50) NULL,
	[Amount] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[ExtraDate] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Business]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Business](
	[BusinessId] [nvarchar](50) NOT NULL,
	[RegisteredBusinessName] [nvarchar](50) NULL,
	[BusinessTradeName] [nvarchar](50) NULL,
	[BusinessRegNo] [nvarchar](50) NULL,
	[BusinessIncomeTaxNo] [nvarchar](50) NULL,
	[BusinessVatNo] [nvarchar](50) NULL,
	[BusinessCity] [nvarchar](50) NULL,
	[Address1] [nvarchar](50) NULL,
	[Address2] [nvarchar](50) NULL,
	[Address3] [nvarchar](50) NULL,
	[Address4] [nvarchar](50) NULL,
	[PostCode] [nvarchar](50) NULL,
	[Phone1] [nvarchar](50) NULL,
	[Phone2] [nvarchar](50) NULL,
	[Phone3] [nvarchar](50) NULL,
	[Phone4] [nvarchar](50) NULL,
	[Phone5] [nvarchar](50) NULL,
	[Email1] [nvarchar](50) NULL,
	[Email2] [nvarchar](50) NULL,
	[Email3] [nvarchar](50) NULL,
	[Email4] [nvarchar](50) NULL,
	[Email5] [nvarchar](50) NULL,
	[Website1] [nvarchar](50) NULL,
	[Website2] [nvarchar](50) NULL,
	[Website3] [nvarchar](50) NULL,
	[Website4] [nvarchar](50) NULL,
	[Website5] [nvarchar](50) NULL,
	[DateModified] [nvarchar](50) NULL,
	[BusinessLogo] [nvarchar](250) NULL,
 CONSTRAINT [PK_BusinessInfo] PRIMARY KEY CLUSTERED 
(
	[BusinessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [nvarchar](50) NULL,
	[ClientType] [nvarchar](50) NULL,
	[ClientName] [nvarchar](50) NULL,
	[ClientSurname] [nvarchar](50) NULL,
	[ClientNationality] [nvarchar](50) NULL,
	[Dob] [nvarchar](50) NULL,
	[MaritalStatus] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[ClientNationalIdNo] [nvarchar](50) NULL,
	[PassportNo] [nvarchar](50) NULL,
	[JuristicRegistrationNo] [nvarchar](50) NULL,
	[JuristicTaxNo] [nvarchar](50) NULL,
	[JuristicType] [nvarchar](50) NULL,
	[Address1] [nvarchar](50) NULL,
	[Address2] [nvarchar](50) NULL,
	[Address3] [nvarchar](50) NULL,
	[Address4] [nvarchar](50) NULL,
	[Address5] [nvarchar](50) NULL,
	[PhoneNumber1] [nvarchar](50) NULL,
	[PhoneNumber2] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[LastModified] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [nvarchar](50) NULL,
	[DesignationId] [nvarchar](50) NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[EmployeeSurname] [nvarchar](50) NULL,
	[EmployeeCode] [nvarchar](50) NULL,
	[Dob] [nvarchar](50) NULL,
	[MaritalStatus] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Qualifications] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber1] [nvarchar](50) NULL,
	[PhoneNumber2] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[JoiningDate] [nvarchar](50) NULL,
	[TerminationDate] [nvarchar](50) NULL,
	[IsActive] [nvarchar](50) NULL,
	[PassportNo] [nvarchar](50) NULL,
	[PassportExpiryDate] [nvarchar](50) NULL,
	[SalaryType] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[BranchName] [nvarchar](50) NULL,
	[BankAccountNumber] [nvarchar](50) NULL,
	[BranchCode] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationId] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NULL,
	[JurisdictionType] [nvarchar](50) NULL,
	[JurisdictionName] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[ExtraDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [nvarchar](50) NOT NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[PurchaseRate] [nvarchar](50) NULL,
	[SalesRate] [nvarchar](50) NULL,
	[MinimumStock] [nvarchar](50) NULL,
	[MaximumStock] [nvarchar](50) NULL,
	[ReorderLevel] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[IsActive] [nvarchar](50) NULL,
	[ProductType] [nvarchar](50) NULL,
	[DateAdded] [nvarchar](50) NULL,
	[DateModified] [nvarchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ReservationId] [nvarchar](50) NULL,
	[ProductId] [nvarchar](50) NULL,
	[ClientId] [nvarchar](50) NULL,
	[LocationId] [nvarchar](50) NULL,
	[ClientName] [nvarchar](50) NULL,
	[ReservationPrice] [nvarchar](50) NULL,
	[NumberOfRooms] [nvarchar](50) NULL,
	[NumberOfExtrabeds] [nvarchar](50) NULL,
	[DateStart] [nvarchar](50) NULL,
	[DateEnd] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [nvarchar](50) NULL,
	[RoleName] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[ExtraDate] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salaries]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salaries](
	[SalaryPackageId] [nvarchar](50) NULL,
	[SalaryPackageName] [nvarchar](50) NULL,
	[BaseAmount] [nvarchar](50) NULL,
	[BenefitsId1] [nvarchar](50) NULL,
	[BenefitsId2] [nvarchar](50) NULL,
	[BenefitsId3] [nvarchar](50) NULL,
	[BenefitsId4] [nvarchar](50) NULL,
	[BenefitsId5] [nvarchar](50) NULL,
	[BenefitsId6] [nvarchar](50) NULL,
	[BenefitsId7] [nvarchar](50) NULL,
	[BenefitsId8] [nvarchar](50) NULL,
	[BenefitsId9] [nvarchar](50) NULL,
	[BenefitsIs10] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[ExtraDate] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesInvoices]    Script Date: 28-Apr-19 4:52:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesInvoices](
	[SalesInvoiceId] [nvarchar](50) NULL,
	[ProductId] [nvarchar](50) NULL,
	[Quantity] [nvarchar](50) NULL,
	[Discount] [nvarchar](50) NULL,
	[TaxAmount] [nvarchar](50) NULL,
	[SubTotalAmount] [nvarchar](50) NULL,
	[NetAmount] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[EmployeeId] [nvarchar](50) NULL,
	[Narration] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerId] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesQuotes]    Script Date: 28-Apr-19 4:53:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesQuotes](
	[SalesQuoteId] [nvarchar](10) NULL,
	[ProductId] [nvarchar](10) NULL,
	[Quantity] [nvarchar](10) NULL,
	[Discount] [nvarchar](10) NULL,
	[TaxAmount] [nvarchar](10) NULL,
	[SubTotalAmount] [nvarchar](10) NULL,
	[NetAmount] [nvarchar](10) NULL,
	[Date] [nvarchar](10) NULL,
	[EmployeeId] [nvarchar](10) NULL,
	[Narration] [nvarchar](10) NULL,
	[CustomerName] [nvarchar](10) NULL,
	[CustomerId] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28-Apr-19 4:53:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[RoleId] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[DateAdded] [nvarchar](50) NULL,
	[LastLogin] [nvarchar](50) NULL
) ON [PRIMARY]
GO
