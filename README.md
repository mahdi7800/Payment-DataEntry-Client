# GitHub Repository Description

A desktop application for secure customer payment entry and processing using SQL Server stored procedures.

---

# README.md

# Payment DataEntry Client Demo

A simple desktop application for secure customer payment entry and processing using **SQL Server Stored Procedures**.

This project shows how a client application can send payment data to SQL Server in a safe and structured way by calling a stored procedure instead of writing direct inline SQL. It is designed as a practical demo for database-driven application development.

## Features

* Secure payment entry form
* Calls SQL Server stored procedures
* Parameterized data submission
* Basic input validation
* Clean and practical demo structure
* Suitable for learning client-to-database integration

## Project Goal

The goal of this project is to show how a desktop application can:

* collect payment information from the user
* validate the data before sending it
* execute a SQL Server stored procedure
* keep the database logic separated from the UI layer

## Technologies Used

* C#
* Windows Forms
* Microsoft SQL Server
* T-SQL Stored Procedures

## How It Works

1. The user enters payment information in the form.
2. The application validates the input.
3. The app sends the data to SQL Server.
4. SQL Server processes the payment through a stored procedure.
5. The result is returned to the application.

## Why Stored Procedures?

Using stored procedures helps keep business logic inside the database layer.
This makes the application easier to maintain, more organized, and safer than building SQL queries directly inside the UI.

## Project Structure

```text
Payment-DataEntry-Client-Demo/
├── README.md
└── source files...
```

## Notes

* This project is intended for learning and demonstration purposes.
* Database objects such as tables and stored procedures should already exist in SQL Server.
* You can extend this project with logging, error handling, and better UI validation.

## Future Improvements

* Add stronger validation
* Add transaction handling
* Show detailed success and error messages
* Add payment history reporting
* Improve UI design

  ------

## Author

Mahdi Davoudi

---

# نسخه فارسی

## توضیح مخزن

یک اپلیکیشن دسکتاپ برای ثبت و پردازش امن پرداخت مشتریان با استفاده از **Stored Procedure** در **SQL Server**.

این پروژه نشان می‌دهد که چگونه یک برنامه سمت کاربر می‌تواند اطلاعات پرداخت را به شکلی امن و ساختارمند به SQL Server ارسال کند و به‌جای نوشتن SQL مستقیم، از Stored Procedure استفاده کند. این پروژه برای یادگیری ارتباط بین برنامه دسکتاپ و پایگاه داده طراحی شده است.

## امکانات

* فرم ورود اطلاعات پرداخت به‌صورت امن
* فراخوانی Stored Procedure در SQL Server
* ارسال پارامتری اطلاعات
* اعتبارسنجی اولیه ورودی‌ها
* ساختار ساده و کاربردی
* مناسب برای یادگیری اتصال برنامه به دیتابیس

## هدف پروژه

هدف این پروژه این است که نشان دهد یک برنامه دسکتاپ چگونه می‌تواند:

* اطلاعات پرداخت را از کاربر دریافت کند
* قبل از ارسال، داده‌ها را بررسی کند
* یک Stored Procedure در SQL Server اجرا کند
* منطق دیتابیس را از لایه رابط کاربری جدا نگه دارد

## تکنولوژی‌های استفاده‌شده

* C#
* Windows Forms
* Microsoft SQL Server
* T-SQL Stored Procedures

## نحوه کار

1. کاربر اطلاعات پرداخت را در فرم وارد می‌کند.
2. برنامه ورودی‌ها را بررسی می‌کند.
3. داده‌ها به SQL Server ارسال می‌شوند.
4. SQL Server عملیات پرداخت را از طریق Stored Procedure پردازش می‌کند.
5. نتیجه به برنامه برگردانده می‌شود.

## چرا Stored Procedure؟

استفاده از Stored Procedure باعث می‌شود منطق کسب‌وکار داخل لایه دیتابیس باقی بماند.
این کار نگهداری برنامه را ساده‌تر، ساختار را منظم‌تر و امنیت را بیشتر می‌کند، نسبت به حالتی که SQL مستقیم داخل رابط کاربری نوشته شود.

## نکات

* این پروژه برای آموزش و نمایش نمونه کار طراحی شده است.
* اشیای دیتابیس مثل جدول‌ها و Stored Procedure باید از قبل در SQL Server وجود داشته باشند.
* می‌توان این پروژه را با ثبت لاگ، مدیریت خطا و اعتبارسنجی بهتر توسعه داد.

## بهبودهای آینده

* اعتبارسنجی قوی‌تر
* مدیریت تراکنش
* نمایش پیام‌های دقیق‌تر برای موفقیت و خطا
* گزارش‌گیری از پرداخت‌ها
* بهبود ظاهر رابط کاربری
------

## نویسنده

Mahdi Davoudi
