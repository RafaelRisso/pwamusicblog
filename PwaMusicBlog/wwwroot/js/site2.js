function addMusic() {

    let blogPost = {
        title: document.getElementById('title').value,
        shortDescription: document.getElementById('description').value,
        tracks: document.getElementById('tracks').value,
        ytlink: document.getElementById('ytlink').value,
        image: document.getElementById('uploadPreview').src
        //sendNotification: notificationService.checkPushEnabled()        
    };

    var blogPostMusicUrl = '/music/';

    fetch(blogPostMusicUrl, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(blogPost)
    }).then(() => {
        //blogService.loadLatestBlogPosts();
        document.getElementById('title').value = '';
        document.getElementById('description').value = '';
        document.getElementById('tracks').value = '';
        document.getElementById('ytlink').value = '';
        document.getElementById('uploadPreview').src = '';
    }).catch(error => console.error('Unable to add item.', error));

}

function LimpaCampos() {
    document.getElementById('title').value = '';
    document.getElementById('description').value = '';
    document.getElementById('tracks').value = '';
    document.getElementById('ytlink').value = '';
    document.getElementById('uploadPreview').src = '';
}