request('http://www.imdb.com/search/title?release_date=' + searchterm + ',' + searchterm + '&title_type=feature', function(err, resp, body){

	$ = cheerio.load(body);

	var resultItemList = new Array();
	var itemList = new Array();

	async.eachLimit($('table.results tr td span.wlb_wrapper'), 1, function( item, callback) {
		
		// fetch List of IMDbId from IMDb-Source-Code

	}, function(err, result){
		var trailerList = new Array();

		async.each(itemList, function(id, callback){ (*@\label{lst:asyncEach}@*)

			// fetch additional Movie-Information from other Sources by IMDbId
			client.get('http://api.traileraddict.com/?imdb='  + id +  '&count=1&width=680', function(data, response){

				// scrape TrailerAddict-Result with Cheerio to get the IFrame
				var trailerResult = cheerio.load(data);
				var videoCode = trailerResult('trailer').html() + '';
				
				callback();
			});
		}, function(err, result){
			// do something with the result
		});
	});
});