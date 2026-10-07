# User Management App

A full-stack CRUD web application built as a Full Stack Development coursework project.

## Stack
- **Backend:** ASP.NET Core Web API (C#), Entity Framework Core, SQLite
- **Frontend:** Vanilla JavaScript (fetch API, async/await), Bootstrap 5, SweetAlert2
- **API Docs:** Swagger / OpenAPI

## Features
- Create, read, update, and delete users via a REST API (`/api/users`)
- Client-side and server-side validation (required fields, email format, birth date checks)
- Live search/filter by name or email
- Dark mode toggle
- Duplicate email prevention

## Running locally
```bash
cd UserManagementApp
dotnet restore
dotnet run
```
Then open the app in your browser at the URL shown in the console (Swagger UI available at `/swagger` in development).

See `Documentation.pdf` for the full project write-up.
