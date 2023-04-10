# Book Store solution for Clean architecture using .NET Core

<h1> The documentation is not compelte yet .... I'm working it and soon I will share it :) w</h1>

<h3>For the database used in this demo goto this <a href="https://www.databasestar.com/sample-bookstore-database/)"> BookStore </a></h3>

<br />
<p align="center">
  <a href="#">
    <img src="img/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Clean Architecture</h3>

  <p align="center">
    Book Strore solution which is built on Clean Architecture with all essential feature using .NET Core!
    <br />

  <p align="left">
    The Clean Architecture approach emphasizes the creation of use cases that are implemented in a loosely coupled manner. 
    These use cases serve as the central organizing structure and are independent of any specific frameworks or 
    technological intricacies.
    <br />
  
  <h4 align="left"> Clean Architecture Overview </h4>
   
  <p align="left>
    In Clean Architecture, the Core of the system revolves around the Domain and Application layers. The Business Logic is 
    situated in these two layers, each containing a different type of business logic. These layers are considered to be 
    the essential components, and the Business layers must not rely on the Presentation and Infrastructure layers. 
    To avoid Business Logic depending on data access or other infrastructure concerns, this dependency is inverted,
    with the Application layer being the basis for infrastructure and implementation details. 
    To accomplish this, abstractions or interfaces are defined in the Application layer, 
    which are subsequently executed by types that are defined in the Infrastructure layer. 
    This architecture is frequently visualized by utilizing a series of concentric circles,
    akin to an onion architecture.
  
   


