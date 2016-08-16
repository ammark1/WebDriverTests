set projectLocation=F:\Automation\LetsAutomateRally\RallyTeam
cd %projectLocation%
set classpath=%projectLocation%\bin;%projectLocation%\libs\*
java org.testng.TestNG F:\RallyTeamWS\RallyTeam\src\com\rallyteam\TestRun\RallyTeamTestSuite.xml
pause