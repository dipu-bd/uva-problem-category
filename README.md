# uva-problem-category    
This project is a subpart of [UVA-Arena](https://github.com/dipu-bd/UVA-Arena). It contains category data that is used by the main project.

## To Contributors      
You can easily contribute to this project to make a rich library of category. First you have to know the **Data Format** used in category files. Then use the editor to create new category files or to edit an existing file.     

## Folder structure   
The category data will be stored separately in **data/** folder. Index of all data can be access directly from this url-
     
	https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/data/INDEX 
	
In data format in INDEX file is as following:

	[
		{ "file" = "cpbook1.cat", "ver" = 0 },
		{ "file" = "cpbook2.cat", "ver" = 0 },
		{ "file" = "cpbook3.cat", "ver" = 0 },
		{ "file" = "test.cat", "ver" = 0 }
	]
	
Here `"ver"` means version. Version increases if there is any changes to the file content.
 	
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
				    { "pnum" = 111, "star" = 0, "note" = "note on this problem" }, 
				    { "pnum" = 222, "star" = 0, "note" = "note on this problem" }, 
				    { "pnum" = 333, "star" = 1, "note" = "note on this problem" },
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
The editor should run in any windows machine. It uses only one external dependency **Newtonsoft.Json**.     

First you have to set the location of INDEX file. The app will load list of category files from it. From the list you can view or edit any category.

**Shortcuts:**      
`F5` = to refresh list     
`F2` = to rename or edit an item      
`Delete` = to delete an item     

**IMPORTANT:** Most of the time the app automatically saves data. But to ensure your edits always click **Save** button. You can not revert any saved edit.    


