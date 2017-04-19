The project implement the  n-tier  design pattern 
constructed from data access layer, bussines logic layer and the application layer
the data layer using entity framework represnting the data base.

the data base is a localDB stored in the AppData folder in the application folder,
it consist of 2 tables only : the students table and the cities table.

the bussines logic project implements 2 methods for retriving the list of all students
and a student by id.

the application layer is a mvc project which implement the mvc designe pattern.
i created a viewmodel named "ViewModelStudentAndCities" for implemnting the autocomplete 
in the Edit view (in the Add view i used a dropDownList without autocomplete).

the index page consist of using partial view using ajax for paging 
and ajax for the delete action.
i used viewbag and hidden input element in the partial view for the new value of the last page (after delete)
and a local storage for accessing it in the index view,
th valdiations consist of data annotion which maps into unotrusive jquery methods.
i used native HTML5 datepicker  for setting the date of birth in the ADD and the EDIT view.
all the javascript code i wrote  is located in the scripts folder in students.js file.



