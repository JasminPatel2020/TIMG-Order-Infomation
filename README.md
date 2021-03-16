# TIMG-Order-Infomation
Order Item Infomration Application contains 

1. Imported of tables using Scaffold-DbContext
2. Created of Data Access layer
3. Created ViewModel as required to fetch information from Order & OrderItem
4. Create OrderItem controller to handle request to fetch information from database
5. Created OrderItem service into app/services and component as well html page to display and to impement business logic in folder orderinfo
6. Added routing into app.shared.module and provider for dependecany injection service
7. On Component and html page added filter by Client Name as well stored data into cache.

------------------------

Needs to be implemented
1. Seperate ClientId, ClientName into different table for normalization
2. Dependency injection to implement DataAccees layer to be replaced with Repository using interface
