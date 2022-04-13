var player;

function onYouTubeIframeAPIReady() {
    player = new YT.Player('video-placeholder', {
        width: 600,
        height: 400,
        videoId: '',
        playerVars: {
            color: 'white',
            playlist: '3vLDiCgTFpY'
        },
        events: {
            onReady: initialize
        }
    });
}
//test pushing to github
function initialize() {

    // Update the controls on load
    updateTimerDisplay();
    updateProgressBar();

    // Clear any old interval.
    clearInterval(time_update_interval);

    // Start interval to update elapsed time display and
    // the elapsed part of the progress bar every second.
    time_update_interval = setInterval(function () {
        updateTimerDisplay();
        updateProgressBar();
    }, 1000)

}

// This function is called by initialize()
function updateTimerDisplay() {
    // Update current time text display.
    $('#current-time').text(formatTime(player.getCurrentTime()));
    $('#duration').text(formatTime(player.getDuration()));
}

function formatTime(time) {
    time = Math.round(time);

    var minutes = Math.floor(time / 60),
        seconds = time - minutes * 60;

    seconds = seconds < 10 ? '0' + seconds : seconds;

    return minutes + ":" + seconds;
}