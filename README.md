
# Ecommerce Application 📖


This is a fullstack web-based ecommerce application for a bookstore. The application allows customers to browse, search and purchase books. The project was built using ASP.NET 6.0, Microsoft Identity for user management, and Entity Framework/SQLServer for the database. The frontend was designed using the Bootswatch theme and bootstrap.

## Libraries and Tools Used
- [DataTables](https://datatables.net/) : displaying CRUD operations in a table
- [SweetAlert2](https://sweetalert2.github.io/) : displaying alerts
- [TinyMCE](https://www.tiny.cloud/?/?utm_source=google_ads&utm_medium=paid_search&utm_campaign=search_branded_ads&utm_term=tinymce&utm_content=tiny_exact_ad2&gad=1&gclid=EAIaIQobChMI5eilkYrE_gIVOPvjBx1ErA_dEAAYASAAEgKsU_D_BwE) : the text editor form
- [Stripe](https://stripe.com/en-ca?utm_campaign=paid_brand-CA_en_Search_Brand_Stripe-19924159419&utm_medium=cpc&utm_source=google&ad_content=653813322897&utm_term=stripe&utm_matchtype=e&utm_adposition=&utm_device=c&gclid=EAIaIQobChMI_I6-mIrE_gIVYZ5bCh3KLA83EAAYASAAEgLhXPD_BwE) : payment solutions
- [Toastr](https://codeseven.github.io/toastr/#:~:text=toastr%20is%20a%20Javascript%20library,Growl%20type%20non%2Dblocking%20notifications.) : notifications
- [Bootstrap](https://getbootstrap.com/) : styling and UI components

## User Features
- Create an account 
- Browse  for books
- Add books to cart
- Get discount on bulk order
- Checkout and make payments using Stripe
- Responsive design for mobile devices


## Administrator Features
- Admin panel to manage books, category type, and cover type
- Responsive design for mobile devices

## Run Locally
Install .net 6.0 via cli or manually

```bash
dotnet-install.sh --runtime dotnet --version 6.0
```


Clone the project

```bash
  git clone https://github.com/aminelkl/bookStoreApp.git
```

Update db string connection and APIKEY in appsettings.json

```bash
  "Stripe": {
    "SecretKey": "YOUR SECRET API KEY",
    "PublishableKey": "YOU PUBLISHABLE API KEY"
  } 

  "ConnectionStrings": {
    "DefaultConnection": "YOUR DATABASE STRING CONNECTION"
  }
```
1. Copy the content of bootstrap.min.css from a template [bootswatchTheme](https://bootswatch.com/)  
2. Paste here : bookStoreApp\BookStoreApp\wwwroot\css/bootswatchTheme.css

```bash
Customize using bootswatch theme
```


Create database package manager

```bash
  add-migration [migrationName]
  update-database
```


![REGISTER](https://user-images.githubusercontent.com/96929412/234168430-23a37426-f790-4a25-9c95-440d3558138a.PNG)
![LOGIN](https://user-images.githubusercontent.com/96929412/234168432-1bb852a8-b863-4c5a-9b9c-29d31141cfa6.PNG)
![HOME](https://user-images.githubusercontent.com/96929412/234168433-82dd8bcf-bce7-46dd-a1cd-1622b161e00b.PNG)
![DETAIL](https://user-images.githubusercontent.com/96929412/234168434-1a7a4c75-3d0f-4f30-b2ff-5d67a505b369.PNG)
![CART](https://user-images.githubusercontent.com/96929412/234168436-48bce789-c45c-49b2-8bf0-29195ce8bd8a.PNG)
![PAYMENT](https://user-images.githubusercontent.com/96929412/234168438-96866497-ce52-44cb-a304-1b841844f5cd.PNG)
![UPDATE](https://user-images.githubusercontent.com/96929412/234168439-28a662ae-b322-495e-a466-5a1144face4c.PNG)



