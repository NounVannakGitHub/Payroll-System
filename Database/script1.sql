USE [Payroll Management System]
GO
/****** Object:  Table [dbo].[tblAttendance]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAttendance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TimeIn] [date] NULL,
	[TimeOut] [date] NULL,
	[Date] [date] NULL,
	[TotalWork] [nvarchar](50) NULL,
	[TotalLate] [nvarchar](50) NULL,
	[Employee] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblBachelor]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBachelor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BachelorID] [nvarchar](50) NULL,
	[Major] [nvarchar](50) NULL,
	[StartYear] [nvarchar](50) NULL,
	[EndYear] [nvarchar](50) NULL,
	[GPA] [decimal](18, 0) NULL,
	[University] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblBonus]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBonus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BonusID] [nvarchar](50) NULL,
	[BonusDateTo] [date] NULL,
	[BonusDateFrom] [date] NULL,
	[BonusAmount] [decimal](18, 0) NULL,
	[BonusType] [nvarchar](50) NULL,
	[Employee] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChild]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChild](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChildID] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChildAddress]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChildAddress](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Home] [nvarchar](50) NULL,
	[Street] [nvarchar](50) NULL,
	[Group] [nvarchar](50) NULL,
	[Village] [nvarchar](50) NULL,
	[Commune] [nvarchar](50) NULL,
	[District] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblContact]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HomeMobile] [nchar](10) NULL,
	[PersonalMobile] [nchar](10) NULL,
	[Email] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Line] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbleAnnualLeave]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbleAnnualLeave](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AnnualLeaveID] [nvarchar](50) NULL,
	[AnnualLeaveValue] [int] NULL,
	[AnnualLeaveAviable] [int] NULL,
	[Employee] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEducation]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEducation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrimarySchool] [nvarchar](max) NULL,
	[SecondarySchool] [nvarchar](max) NULL,
	[HighSchool] [nvarchar](max) NULL,
	[University] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Age] [nvarchar](50) NULL,
	[PersonalStatus] [nvarchar](max) NULL,
	[Religion] [nvarchar](50) NULL,
	[HireDate] [date] NULL,
	[Photo] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[DOB] [date] NULL,
	[PlaceOfBirth] [nvarchar](max) NULL,
	[Education] [nvarchar](50) NULL,
	[Family] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblFamily]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFamily](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Parents] [nvarchar](max) NULL,
	[Spouses] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHighSchool]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHighSchool](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HighSchoolName] [nvarchar](max) NULL,
	[HighSchoolStartYear] [nvarchar](max) NULL,
	[HighSchoolEndYear] [nvarchar](max) NULL,
	[Grade] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoliday]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoliday](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HolidayID] [nvarchar](50) NULL,
	[HolidayDate] [date] NULL,
	[HolidayReason] [nvarchar](max) NULL,
	[HolidayStatus] [nvarchar](max) NULL,
	[HolidayName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblInsurance]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInsurance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InsuranceID] [nvarchar](max) NULL,
	[InsuranceType] [nvarchar](max) NULL,
	[InsuranceAmount] [nvarchar](max) NULL,
	[Employee] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblJob]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJob](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobID] [nvarchar](50) NULL,
	[ShortName] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLeave]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLeave](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LeaveID] [nvarchar](max) NULL,
	[LeaveDate] [date] NULL,
	[LeaveReason] [nvarchar](max) NULL,
	[Employee] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLicense]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLicense](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LicenseID] [nvarchar](50) NULL,
	[LicenseCode] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLoan]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoanID] [nvarchar](50) NULL,
	[LoanAmount] [decimal](18, 0) NULL,
	[LoanPay] [decimal](18, 0) NULL,
	[LoanRate] [decimal](18, 0) NULL,
	[LoanStartDate] [date] NULL,
	[LoanEndDate] [date] NULL,
	[LoanType] [nvarchar](max) NULL,
	[Employee] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMajor]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMajor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MajorID] [nvarchar](50) NULL,
	[MajorName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMasterDegree]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMasterDegree](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MasterID] [nvarchar](50) NULL,
	[MasterMajor] [nvarchar](max) NULL,
	[MasterStartYear] [nvarchar](50) NULL,
	[MasterEndYear] [nvarchar](50) NULL,
	[GPA] [nvarchar](50) NULL,
	[Unviersity] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblParents]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblParents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FatherFirstName] [nvarchar](50) NULL,
	[FatherLastName] [nvarchar](50) NULL,
	[FatherAge] [nvarchar](50) NULL,
	[FatherLife] [nvarchar](max) NULL,
	[MotherFirstName] [nvarchar](50) NULL,
	[MotherLastName] [nvarchar](50) NULL,
	[MotherAge] [nvarchar](50) NULL,
	[MotherLife] [nvarchar](50) NULL,
	[ParentsAddress] [nvarchar](max) NULL,
	[ParentsContact] [nvarchar](max) NULL,
	[ParentsStatus] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhD]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhDID] [nvarchar](50) NULL,
	[PhDMajor] [nvarchar](max) NULL,
	[PhDStartYear] [nvarchar](50) NULL,
	[PhDEndYear] [nvarchar](50) NULL,
	[University] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhoto]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhoto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhotoID] [nvarchar](50) NULL,
	[PhotoName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPosition]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPosition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PositionID] [nvarchar](50) NULL,
	[PositionName] [nvarchar](max) NULL,
	[PositionType] [nvarchar](max) NULL,
	[Salary] [decimal](18, 0) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPreAttandance]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPreAttandance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PreAttandanceID] [nvarchar](50) NULL,
	[PreAttandanceDateFrom] [date] NULL,
	[PreAttandanceDateTo] [date] NULL,
	[PreAttandanceReason] [nvarchar](max) NULL,
	[PreAttandanceType] [nvarchar](max) NULL,
	[PreAttandanceTotal] [nvarchar](50) NULL,
	[Employee] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPrimarySchool]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPrimarySchool](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrimarySchoolName] [nvarchar](max) NULL,
	[PrimarySchoolStartYear] [nvarchar](50) NULL,
	[PrimarySchoolEndYear] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSecondarySchool]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSecondarySchool](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SecondarySchoolName] [nvarchar](max) NULL,
	[SecondarySchoolStartYear] [nvarchar](50) NULL,
	[SecondarySchoolEndYear] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSpouses]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSpouses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SpousesID] [nvarchar](50) NULL,
	[Total] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Child] [nvarchar](max) NULL,
	[Age] [nvarchar](50) NULL,
	[Occupation] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Contact] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUniversity]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUniversity](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UniversityID] [nvarchar](50) NULL,
	[ShortName] [nvarchar](50) NULL,
	[FullName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 12-Sep-2015 4:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](50) NULL,
	[Position] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblJob] ON 

INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (1, N'1         ', N'CA        ', N'Credit Officer')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (2, N'2         ', N'Teller    ', N'Teller')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (3, N'3         ', N'Acc       ', N'Accountant')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (4, N'4         ', N'ITO       ', N'IT Officer')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (5, N'5         ', N'ITU       ', N'IT Unit')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (6, N'6         ', N'ITM       ', N'IT Manager')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (7, N'7         ', N'ITD       ', N'IT Department')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (8, N'8         ', N'FM        ', N'Finance Manager')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (9, N'9         ', N'OPM       ', N'Operation Manager')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (10, N'10        ', N'HR        ', N'Human Resource')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (11, N'11        ', N'IAM       ', N'Internal Audit Manager')
INSERT [dbo].[tblJob] ([ID], [JobID], [ShortName], [FullName]) VALUES (12, N'12        ', N'ADM       ', N'Admin Manager')
SET IDENTITY_INSERT [dbo].[tblJob] OFF
SET IDENTITY_INSERT [dbo].[tblMajor] ON 

INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (1, N'1         ', N'Information of Technology')
INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (2, N'2         ', N'English Literature')
INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (3, N'3         ', N'Khmer Literature')
INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (4, N'4         ', N'Account')
INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (5, N'5         ', N'Banking')
INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (6, N'6         ', N'Marketing')
INSERT [dbo].[tblMajor] ([ID], [MajorID], [MajorName]) VALUES (7, N'7         ', N'Lawer')
SET IDENTITY_INSERT [dbo].[tblMajor] OFF
SET IDENTITY_INSERT [dbo].[tblUniversity] ON 

INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (1, N'1         ', N'RUPP      ', N'Royal University of Phnom Penh')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (2, N'2         ', N'RULE      ', N'Royal University of Law and Economics')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (3, N'3         ', N'PUC       ', N'Pannasastra University of Cambodia')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (4, N'4         ', N'NU        ', N'Norton University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (5, N'5         ', N'NUM       ', N'National University of Management')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (6, N'6         ', N'ITC       ', N'Institute of Technology of Cambodia')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (7, N'7         ', N'CMU       ', N'Cambodian Mekong University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (8, N'8         ', N'BBU       ', N'Build Bright University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (9, N'9         ', N'UC        ', N'University of Cambodia')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (10, N'10        ', N'RUA       ', N'Royal University of Agriculture')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (11, N'11        ', N'IUC       ', N'International University of Cambodia')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (12, N'12        ', N'RUFA      ', N'Royal University of Fine Arts')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (13, N'13        ', N'UHS       ', N'University of Health Science')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (14, N'14        ', N'UP        ', N'University of Puthisastra')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (15, N'15        ', N'KU        ', N'Khemarak University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (16, N'16        ', N'AEU       ', N'Asia Euro University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (17, N'17        ', N'PPIU      ', N'Phnom Penh International University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (18, N'18        ', N'UB        ', N'University of Battambang')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (19, N'19        ', N'IIC       ', N'IIC Universtiy of Technology')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (20, N'20        ', N'RIC       ', N'Raffles International College')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (21, N'21        ', N'CUP       ', N'Chamroeun University of Polytechnology')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (22, N'22        ', N'MU        ', N'Meanchey University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (23, N'23        ', N'AU        ', N'Angkor University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (24, N'24        ', N'PCU       ', N'Panha Chiet University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (25, N'25        ', N'UME       ', N'University of Management and Economics')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (26, N'26        ', N'CUS       ', N'Cambodian University of Specailties')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (27, N'27        ', N'SRU       ', N'Svay Rieng Univeristy')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (28, N'28        ', N'ICS       ', N'ICS University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (29, N'29        ', N'HRU       ', N'Human Resource University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (30, N'30        ', N'ERA       ', N'Ecole Royale d''Administration')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (31, N'31        ', N'CARDI     ', N'Cambodian Agricultural Research and Development Institute ')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (32, N'32        ', N'ITC       ', N'Institute of Technology of Cambodia')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (33, N'33        ', N'CSUKM     ', N'Chea Sim University of Kamchay Mear')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (34, N'34        ', N'NIE       ', N'National Institute of Education')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (35, N'35        ', N'NPIC      ', N'National Polytechnic Institute of Cambodia')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (36, N'36        ', N'NTTI      ', N'National Technical Training Institute')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (37, N'37        ', N'PLNCA     ', N'Prek Leap National College of Agriculture')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (38, N'38        ', N'NIB       ', N'National Institute of Business')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (39, N'39        ', N'PKPI      ', N'Preah Kossomak Polytechnic Institute')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (40, N'40        ', N'ITI       ', N'Industrial Technical Institute')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (41, N'41        ', N'DIU       ', N'Dewey International University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (42, N'42        ', N'BIU       ', N'Beltei International University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (43, N'43        ', N'PPIT      ', N'Phnom Penh Institute of Technology')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (44, N'44        ', N'CBS       ', N'CamEd Business School')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (45, N'45        ', N'SPI       ', N'Saint Paul Institute')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (46, N'46        ', N'AUPP      ', N'American University of Phnom Penh')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (47, N'47        ', N'VI        ', N'Vanda Institute')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (48, N'48        ', N'ZU        ', N'Zaman University')
INSERT [dbo].[tblUniversity] ([ID], [UniversityID], [ShortName], [FullName]) VALUES (49, N'49        ', N'CICI      ', N'Cambodia International Cooperation Institute')
SET IDENTITY_INSERT [dbo].[tblUniversity] OFF
