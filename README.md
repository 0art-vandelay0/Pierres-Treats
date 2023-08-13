# &#x1F36D; **Pierre's Bakery and Treats** &#x1F368;

#### **By Casey Hill**

#### A MVC database web application that allows users to browse menu items and flavors used in the items. &#x1F36C; &#x1F36E; &#x1F369;

#### ...._"Good bread is the most fundamentally satisfying of all foods; and good bread with fresh butter, the greatest of feasts."_ - James Beard

## **Technologies Used**

-   C#
-   .NET 6.0.402
-   Entity Framework Core version 6.0
-   EFCore Migration
-   EFCore Design
-   EFCore Identity
-   dontnet CLI
-   MSBuild
-   VS Code
-   MySql Server
-   MySQL Workbench
-   SQL
-   git
-   GitHub

## **Description**

Welcome back to Pierre's Bakery!

On this site you can browse all of our treats and their flavors and also check our list of flavors we use and which treats contain them.

Use the Dropdown menu in the upper right hand corner to navigate accross the site. We use authentication so register and log in to add treats and flavors, or just browse if you prefer to not create an account.

## **Setup/Installation Requirements** &#x1F4BB;

<details>
<summary> Initial Setup </summary>

-   Clone this repository to your local flavor.
    ```bash
    $ git clone https://github.com/0art-vandelay0/Pierres-Treats
    ```
-   Open VS Code (or your IDE of choice).
-   Open the top level directory you just cloned.
</details>

<details>
<summary> Database Setup </summary>

-   Use a MySql RDBMS like MySql Workbench to import/upload the `casey_hill.sql` file and create your database.
-   In your 'PierresTreats' Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

    <pre><code>{
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=pierres-treats;uid=[YOUR-UID];pwd=[YOUR-PASSWORD];"
        }
    }
    </code></pre>

-   Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
</details>

<details>
<summary> Finish Setup </summary>

-   In your terminal:

    From your root folder, change directory to PierresTreats.

    ```bash
    $ cd PierresTreats
    ```

    And enter the following commands:

    ```bash
    $ dotnet build
    ```

    ```bash
    $ dotnet run
    ```

    (or `dotnet watch run` to view and see edits in real time).

-   A web page will automatically open in your browser
-   Use the navigation at the bottom of the page to view Treats or Flavors (both will be empty to start)
-   Follow the links based on what every your needs are.
</details>

#### Debugging

<details>
<summary> If the program does not run...</summary>

-   Check that you have the appropriate packages installed to run dotnet
    -   In your Terminal, enter the following commands:<br>
        ```bash
        $ dotnet tool install --global dotnet-ef --version 6.0.0
        ```
        ```bash
        $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
        ```
        ```bash
        $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
        ```
-   Try creating a `global.json` file in the PierresTreats dir that contains the following code to override the default version, if your version exceeds .NET 6.0:<br>
    <pre><code>{
        "sdk": {
            "version": "6.0.402"
        }
    }
    </code></pre>

    </details>

## **Known Bugs**

-   There is currently neither a Delete nor Edit/Update functionality from within the program.
    To delete or edit, use you RDBMS Software or Querey MySql Server at the command line with your existing local setup.

## License

Please contact [caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=You%20are%20amazing...) with any the following:

-   Found bugs &#x1F41E;
-   Alterations and improvements
-   General Questions
-   Any contributions you would like to make! &#x1F5DD;

Copyright (c) 06/16/2023 Casey Hill
