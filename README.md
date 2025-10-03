# Invoice Management

## 📁 Project Structure

Invoice Management/
├── Core/ # Business Logic & Domain Layer

│ ├── Entities/ # Domain Entities

│ │ ├── User.cs

│ │ └── Invoice.cs

│ ├── Interfaces/ # Contracts & Abstractions

│ │ ├── Repositories/ # Data Access Contracts

│ │ │ ├── IInvoiceRepository.cs

│ │ │ └── IUserRepository.cs

│ │ └── Services/ # Business Service Contracts

│ │ ├── IInvoiceService.cs

│ │ └── IUserService.cs

│ ├── Services/ # Business Logic Implementation

│ │ ├── InvoiceService.cs

│ │ └── UserService.cs

│ ├── DTOs/ # Data Transfer Objects

│ │ ├── Requests/ # Input Models

│ │ │ ├── CreateInvoiceRequest.cs

│ │ │ └── UpdateInvoiceRequest.cs

│ │ └── Responses/ # Output Models

│ │ ├── InvoiceResponse.cs

│ │ └── UserResult.cs

│ └── Exceptions/ # Custom Exceptions

├── Infrastructure/ # External Concerns & Data Access

│ ├── Data/ # Data Access Layer

│ │ ├── AppDbContext.cs

│ │ └── Configurations/

│ ├── Repositories/ # Repository Implementations

│ │ ├── UserRepository.cs

│ │ └── InvoiceRepository.cs

├── Presentation/ # Presentation Logic


│ └── Forms/ # Form Definitions (Code-behind)

│ ├── MainForm.cs

├── Program.cs # Application Entry Point