# Integration Tests MVP

A modular integration test framework for testing multiple connector implementations with shared test classes.

## Project Structure

- **IntegrationTests.BaseTests**: Core test framework with base test classes
  - `BrowserBaseTest.cs` / `HttpClientBaseTest.cs`: Base test classes for HTTP testing
  - `BrowserTests.cs` / `HttpClientTests.cs`: Common test implementations with features
  - `SkipForConnectorsAttribute.cs`: Attribute to conditionally skip tests for specific connectors
  - `ConnectorTestDiscoverer.cs`: Custom test discoverer for connector-specific test filtering

- **IntegrationTests.AspNetCore**: ASP.NET Core connector implementation
- **IntegrationTests.Akamai**: Akamai connector implementation

## Running Tests

### Run all tests:
```
dotnet test
```

### Run tests for specific connector:
```powershell
# Set connector type
$env:CURRENT_CONNECTOR_TYPE="NetCore"

# Run tests
dotnet test IntegrationTests.AspNetCore/IntegrationTests.AspNetCore.csproj
```

### Run tests by trait:
```
dotnet test --filter "Feature=Normalization"
```

## Configuration

Tests can be configured using environment variables:

- `CURRENT_CONNECTOR_TYPE`: Specifies which connector is being tested (e.g., "Akamai", "NetCore")
- `CONNECTOR_ENDPOINT`: Base URL for HTTP requests (defaults to "http://localhost:5000/")

Example:
```powershell
$env:CONNECTOR_ENDPOINT="https://dev-server:8080/"
$env:CURRENT_CONNECTOR_TYPE="Akamai"
dotnet test IntegrationTests.Akamai/IntegrationTests.Akamai.csproj
```

## Extending

### Adding a new connector:

1. Create a new project with connector-specific tests
2. Reference the IntegrationTests.Base project
3. Create test classes that inherit from base test classes
4. Set up connector-specific configuration

### Adding a new test category:

1. Add test methods to the existing test classes or create new ones
2. Apply appropriate trait attributes (e.g., `[Trait("Feature", "YourFeatureName")]`)
3. Use `[SkipForConnectorsAttribute]`