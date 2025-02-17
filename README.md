# Membership Fee Calculator

## Author
Nikita Plamadeala

Melissa Louise Bangloy

## Description
The **Membership Fee Calculator** is a Windows Forms application developed in C# that allows users to:
- Enter personal details (first and last name)
- Select a membership type
- Choose additional options (Yoga, Karate, Trainer)
- Calculate monthly and total membership fees
- Register and save membership details to a CSV file
- View registered memberships in a separate form

## Features
- **User-friendly Interface:** Windows Forms-based GUI with clear input fields and buttons.
- **Dynamic Fee Calculation:** Calculates monthly and total membership fees based on user selections.
- **Data Persistence:** Saves registered membership data to a .csv file.
- **Validation Checks:** Prevents incorrect membership length entries.
- **Data Viewing:** Allows users to view saved membership registrations.

## Installation
### Prerequisites
- Windows OS
- .NET Framework
- Visual Studio (or any C# IDE)

### Setup Instructions
1. Clone or download the repository.
2. Open the solution (`.sln`) file in Visual Studio.
3. Build and run the project.

## Usage
1. Enter your first and last name.
2. Choose a membership type (Adult, Senior, Child, Student).
3. Select additional options if needed.
4. Enter the number of months for the membership.
5. Click **Calculate Fees** to display the monthly and total cost.
6. Click **Register** to save the details.
7. Click **View** to see registered memberships.

## File Structure
- `Form1.cs` - Main form handling user input, calculations, and file operations.
- `Membership.cs` - Defines membership types and fee structures.
- `Options.cs` - Defines options types and fee structure.
- `ViewForm.cs` - Form for viewing saved membership data.
- `memberships.csv` - File storing registered membership details.
