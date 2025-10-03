# Invoice Management

## 📁 Project Structure

Invoice Management/

### Core Layer
**Purpose**: Contains business rules and domain logic

#### Entities/
- **User.cs**
- **Invoice.cs**

#### Interfaces/
- **Repositories/**
  - **IUserRepository.cs**
  - **IInvoiceRepository.cs**
- **Services/**
  - **IUserService.cs**
  - **IInvoiceService.cs**

#### Services/
- **UserService.cs**
- **InvoiceService.cs**

#### DTOs/
- **Requests/**
  - **CreateInvoiceRequest.cs**
  - **UpdateInvoiceRequest.cs**
- **Responses/**
  - **InvoiceResponse.cs**
  - **Result.cs**

#### Exceptions/

### Infrastructure Layer
**Purpose**: Handles external concerns and data access

#### Data/
- **AppDbContext.cs**: Entity Framework database context
- **Configurations/**: Entity configuration classes

#### Repositories/
- **UserRepository.cs**
- **InvoiceRepository.cs**

### Presentation Layer
**Purpose**: Contains presentation logic and view models

#### ViewModels/

#### Forms/
- **MainForm.cs**

**Program.cs**: Application entry point and DI configuration

--------------------------
### Layer Dependencies
- **Core**: No dependencies on other projects
- **Infrastructure**: Depends on Core (for interfaces)
- **Presentation**: Depends on Core (for services and DTOs)

### Request Flow Example
1. **User Action** → UI Layer (Button click)
2. **UI Layer** → Presentation Layer (ViewModel method call)
3. **Presentation Layer** → Core Layer (Service method call)
4. **Core Layer** → Infrastructure Layer (Repository method call)
5. **Infrastructure Layer** → Database (Entity Framework)
6. **Response flows back up the chain**