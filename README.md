# uva-problem-category    
This project is a subpart of [UVA-Arena](https://github.com/dipu-bd/UVA-Arena). It contains category data that is used by the main project.

## To Contributors      
You can easily contribute to this project to make a rich library of category.    
First you have to know the **Data Format** used in category files.     
Then use the editor to create new category files or to edit an existing file.     

## Folder structure   
The category data will be stored separately in **src/** folder. Index of all data can be access directly from this url-
     
	https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/INDEX 
	
In data format in INDEX file is as following:

	[ 
		{"book"="book1", "link"="src/file1.cat"},
		{"book"="book2", "link"="src/file2.cat"},
		{"book"="book3", "link"="src/file3.cat"},
		...
	]

Meaning of the properties :          
1) "book" : denotes the title of the category.      
2) "link" : denotes the address of the category file.      

The address of the category file is in this format:      

    src/{filename}.cat  
	
The file can be downloaded from this url:     

    https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/{link}  

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

