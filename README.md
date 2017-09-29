# SweetAlertForMVC
You can use SweetAlert to trigger by the controller

## Getting Started

First off all create a Asp.NET MVC project and install SweetAlert from Nuget Package Manager

### Installing

```
Install-Package SweetAlert.Bootstrap -Version 1.0.1
```

And use this class

```
SweetAlertHelper.cs
```
## Running the example
## Controller Side
```
ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Error", "Username or Password Wrong", SweetAlertMessageType.error);
```
## Markup Side
```
@section scripts{
    <script type="text/javascript">
        @Html.Raw(ViewBag.SweetAlertShowMessage)
    </script>
}
```
## Deployment

.Net Framework 4.5.2

## Built With

* [SweetAlert ](https://sweetalert.js.org/) - A beautiful replacement for success messages

## Authors

* **Sertunc SELEN** - *Initial work*

## License

This project is licensed under The FreeType License (FTL)
