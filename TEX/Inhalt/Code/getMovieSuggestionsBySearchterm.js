var getMovieSuggestionsBySearchterm = function(searchterm, callback){
	async.parallel({
		rotten_result: function(callback){
			getSuggestionsFromRottenTomatoes(searchterm, callback);
		},
		imdb_result: function(callback){
			getSuggestionsFromIMDb(searchterm, callback);
		}
	},
	function(err, results) {
		if(err){
			callback(err, searchterm);
		} else {
			var resultset = results.rotten_result.concat(results.imdb_result);
			callback(null, resultset);
		}
	});
}