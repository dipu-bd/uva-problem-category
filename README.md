# uva-problem-category    
This project is a subpart of [UVA-Arena](https://github.com/dipu-bd/UVA-Arena). It contains category data that is used by the main project.

## To Contributors      
You can easily contribute to this project to make a rich library of category.    
First you have to know the **Data Format** used in category files.     
Then use the editor to create new category files or to edit an existing file.     

## Folder structure   
The category data will be stored separately in **data/** folder. Index of all data can be access directly from this url-
     
	https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/data/INDEX 
	
In data format in INDEX file is as following:

	[ 
		"file1.cat",
		"file2.cat",
		"file3.cat",
		...
	]
 	
The files can be downloaded from this url:     

    https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/data/{filename}  

## Data format      
The data format for each category file is as following:      

	{
	    "name" = "Category folder name",
	    "note" = "note on this category",
	    "problems" = [ ],
	    "branches" = 
		[
		    {
			    "name" = "Branch name",
				"note" = "note on this branch",
				"problems" = 
				[
				    { "number" = 111, star = 0, note = "note on this problem" }, 
				    { "number" = 222, star = 0, note = "note on this problem" }, 
				    { "number" = 333, star = 1, note = "note on this problem" },
					...
				],
				"branches" = 
				[ 
					...
				]
			}, 
			...
		]
	}
	
## Editor
This project is ongoing. More info will come later.   

