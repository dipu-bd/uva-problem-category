# uva-problem-category    
*This project is a subpart of [UVA-Arena](https://github.com/dipu-bd/UVA-Arena). It contains category data that is used by the main project.*    

Category of a problem is the algorithm or strategy to follow to solve the problem. e.g. "100 - 3n + 1 problem" can be categoried as "Ad Hoc problem". "280 - Vertex" is "Graph Traversal". Visit http://uhunt.felix-halim.net/ to get more example.

## To Contributors      
Help us to make a rich library of category files. You can create a new Category file or edit an existing category file easily with the [Editor App](https://github.com/dipu-bd/uva-problem-category/tree/master/editor/app). The editor app will run on windows platform only. 

Developers of other platform can view or edit raw Category files by themselves. To do this please take a look at the file format in the following section. Also if anyone developed their own app please share.    

## Folder structure and file format
The category data will be stored separately in **data/** folder. Index of all data can be access directly from this url-
     
	https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/data/INDEX 
	
The data format in INDEX file is as following:

	[
		{ "file": "cpbook1.cat", "ver": 0 },
		{ "file": "cpbook2.cat", "ver": 0 },
		{ "file": "cpbook3.cat", "ver": 0 },
		...
	]
	
Here `"ver"` means version. Version increases if there is any changes to the file content.
 	
The files can be downloaded from this url:     

    https://raw.githubusercontent.com/dipu-bd/uva-problem-category/master/data/{filename}  

## Data format      
The data format for each category file is as following:      

	{
	    "name": "Category root",
	    "note": "note on this category",
	    "problems": null,
	    "branches": 
		[
		    {
			    "name": "Branch name",
				"note": "note on this branch",
				"problems": 
				[
				    { "pnum": 111, "star": false, "note": "note on this problem" }, 
				    { "pnum": 222, "star": true, "note": "note on this problem" }, 
				    { "pnum": 333, "star": false, "note": "note on this problem" },
					...
				],
				"branches": 
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


