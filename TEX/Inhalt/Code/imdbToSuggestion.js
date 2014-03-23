suggestionSchema.virtual('imdbToSuggestion').set(function (imdbResult) {
	this.mediaType = 'video';
	this.mediaSubtype = 'movie';
	var suggestedDate = new Date();
	suggestedDate.setFullYear(imdbResult._year_data);
	this.year = imdbResult._year_data;
	this.suggestedDate = suggestedDate;
	this.title = imdbResult.title;
	this.img_url = 'http://placehold.it/60x60';
	this.id = this._id;
	this.source = 'IMDb';
});