# Selenium Java Test Automation Framework

## 📌 Overview

Designed and developed a Selenium WebDriver-based automation framework using C# and .NET to support scalable and maintainable UI test automation. The framework leverages the Page Object Model (POM) design pattern to separate test logic from UI interactions, improving readability, reusability, and long-term maintainability.

This project demonstrates real-world automation practices, including synchronization using explicit waits, structured test design, and validation strategies aligned with modern QA and Agile workflows.

## 🧰 Tech Stack

* C#
* .NET
* Selenium WebDriver
* NUnit
* DotNetSeleniumExtras.WaitHelpers

## 🏗️ Framework Design

- Built using the Page Object Model (POM) to promote separation of concerns
- Centralized element synchronization using a reusable WaitHelper
- Clean separation of Pages, Tests, and Utilities
- Designed with scalability in mind to support additional test cases and enhancements

## 🚀 Features

- Implemented Page Object Model (POM) for scalable and maintainable test design
- Integrated explicit waits via a reusable WaitHelper for reliable element interaction
- Utilized NUnit for test execution, annotations, and assertions
- Implemented robust element locators using CSS selectors and IDs
- Automated positive and negative UI test scenarios
- Structured setup and teardown using NUnit lifecycle annotations

## 🧪 Test Scenarios

✅ Valid Login Test
Navigate to login page
Enter valid credentials
Verify successful login via confirmation message

❌ Invalid Login Test
Navigate to login page
Enter invalid credentials
Verify error message is displayed


## 🛠️ Setup & Execution

1. Clone the repository
2. Open the project in Visual Studio
3. Restore NuGet packages
4. Run tests using Test Explorer or via CLI:

```bash
dotnet test
```

## 📈 Future Improvements

- Implement BaseTest class for centralized driver management
- Add DriverFactory to support multiple browsers
- Introduce configuration management using appsettings.json
- Integrate reporting (ExtentReports or Allure)
- Enable parallel test execution
- Integrate with CI/CD pipelines (GitHub Actions / Azure DevOps)

🔄 Java Version

A similar automation framework built using Java:
👉 https://github.com/mlj416/selenium-java-automation.git

## 👨‍💻 Author

Mike Jimenez
