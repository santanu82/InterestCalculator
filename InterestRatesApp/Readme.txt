I have crearted InterestRatesApp Console app is the main app. I have following class library projects like

1)InterestCalculator projects contains all the logic
2)InterestCalculator.Test is the test project 
3)FactoryCalculatory project contains all present conditions for calculating the interest as well as all the future conditions for calculating the interest.

The project is developed in TDD fashion so I first write down the test cases and make them pass which eventually fails as 
no actual implementation were there and then wrote the minimum code to make it pass and then go for actual implementation and finally refactoring.