# Diff Client

This is a simple windows application created for testing the [Diff Service](https://github.com/erasmosoares/SimpleService). Please check
the readme for more information.

Diff service is an interface that accepts JSON base data to compare differences between two JSON files. Into the diff client there is no possibility
for posting new JSON files, but you can use [Postman](https://www.getpostman.com/) in order to create new files. Running the Diff Service
migrations you will probably note a seed migration that will populate some files for testing.


<h2> Usage </h2>

Before usign Diff Client, make sure you have the [Diff Service](https://github.com/erasmosoares/SimpleService) running in other visual studio 
instance. The diff client is a windows application, if you are not using the release binary file, just run the application.

 - Make sure you have a correct URIs setup. For now this is not available into the UI, so open the viewmodel folder and find a
 JSONDiffToolViewModel class. Make sure you have correct URI_GET_DATA address and URI_POST address.
 
 ![URIs](https://www.dropbox.com/s/cdz5ucu92h4besv/Untitled.png?raw=1)
 
 <h2> Test Dashboard </h2>
 
 Content
 
 * **Retrieve All Data**
  
  Get all files stored in the database
  
  
 * **Retrieve Single Data**
 
 Get a single file stored in the database, file ID must be informed in the File ID field
 
  * **Left / Right Tab - File ID**
  
  Informing the ID and pressing GO will add the JSON related to the ID into a side. The service response is given into the
  field below.
  
  * **DIFF and result**
  
  Once you have two files added on each side of the Diff Tool, pressing the Diff button will made a call to the service. The result will
  be generated into the result field.
 
 ![Main Screen](https://www.dropbox.com/s/kjce9ujuc9fy473/Untitled2.png?raw=1)
 
 <h2> Improvements </h2>
  
  A web application would be available online so that everyone would access the diff services.
 
