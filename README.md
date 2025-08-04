# Multiple-choice test maker

This is a final exam project for the Software Application development subject. It is a desktop app for creating and taking exams with multiple-choice questions. 

## Features
- Students can check their signed-up classes, exams they have left and their scores.
- Students can attend the exams at the time of their choosing.
- Admin and teachers can create and update exams based off their needs.
- Teachers can check grade reports based on class grades.

## Installation

### Prerequisites
- Dotnet version 4.7.2

### Walkthough
1. Step 1: Clone the repo to your local machine
```bash
git clone https://github.com/Hoang4778/Multiple-choice-test-maker.git
```

2. Step 2: Checkout to the "development" branch before starting the project

3. Step 3: In your SQL Server, create a database named "TestMaker", and import the file "TestMaker - Database.sql" from the project root directory

4. Step 4: Start the project by running the following command or click the Run button at the top of your IDE if you are using Visual Studio:
```bash
dotnet run
```

## Usage
1. For students: Log in from the start with student account (you will find the student accounts at table "Contestant" of the database), then sign up for classes to see the exams and take the tests.
2. For administrator: Log in at the beginning of the app (details of the admin account is in table "AdminAccount" inside the database), then you can create classes and exams however you want.
