RESTful Routing
Route Name | URL Path | HTTP Method | Purpose |
| ------------- |:-------------:| -----:|
| Index | /items | GET | Display list of all items |
| New | /items/new | GET | Offers form to create new Item |
| Create | /items | POST | Creates new Item on server |
| Show | /items/:id | GET | Displays one specific Item's details |
| Edit | /items/:id/edit | GET | Offers form to edit specific item |
| Update | /items/:id | PATCH (via POST) | Updates specific Item on server |
| Destroy | /items/:id | DELETE (via POST) | Deletes specific Item |
