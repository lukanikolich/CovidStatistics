Run Application:
  - Download Git repository
  - Open CovidStatistics.sln in Visual Studio
  - Cick Build -> Rebuild Solution
  - Run IIS Express
 
Test in Postman:
  - import collection CovidStatistics/Postman/CovidStatistics.postman_collection.json
  - if Authorization is not set:
    - in Authorization choose Type = Basic Auth
    - user 1: username: test, password: test
    - user 2: username gollum, password: myprecious
