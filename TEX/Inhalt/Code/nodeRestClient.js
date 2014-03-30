client.get('http://api.traileraddict.com/?imdb='  + id +  '&count=1&width=680', function(data, response){
	// response contains html-code with the iFrame that contains the Movie-Trailer
});