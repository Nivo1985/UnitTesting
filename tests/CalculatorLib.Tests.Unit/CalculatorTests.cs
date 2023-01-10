﻿using CalculatorLib;
using Xunit.Abstractions;

namespace CalculatorLibTests;

public class CalculatorTests: IAsyncLifetime
{
    //Arrange
    private readonly Calculator _sutCalculator = new();
    private readonly Guid _sutGuid = Guid.NewGuid();

    private readonly ITestOutputHelper _testOutputHelper;
    
    public CalculatorTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _testOutputHelper.WriteLine("TEST SETUP CTOR");
    }
    
    [Fact]
    public void Add_Should_Add_Integers()
    {
        // Act
        var result = _sutCalculator.Add(3, 2);
        
        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void TestGuidUniquenessOne()
    {
        _testOutputHelper.WriteLine(_sutGuid.ToString());
    } 
    
    [Fact]
    public void TestGuidUniquenessTwo()
    {
        _testOutputHelper.WriteLine(_sutGuid.ToString());
    }
    
    public async Task InitializeAsync()
    {
        _testOutputHelper.WriteLine("TEST InitializeAsync()");
        await Task.Delay(1);
    }

    public async Task DisposeAsync()
    {
        _testOutputHelper.WriteLine("TEST DisposeAsync()");
        await Task.Delay(1);
    }
}