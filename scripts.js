/* scripts.js */
function acceptConsent() {
    localStorage.setItem('consent', 'true');
    document.getElementById('consent-banner').style.display = 'none';
}

document.addEventListener('DOMContentLoaded', function() {
    var consentBanner = document.getElementById('consent-banner');
    var consent = localStorage.getItem('consent');
    if (!consent) {
        consentBanner.style.display = 'block';
    }

    var gridHeroesElement = document.getElementById('gridHeroCount');
    if (gridHeroesElement) {
        var gridHeroCount = localStorage.getItem('gridHeroCount') || 0;
        gridHeroCount++;
        localStorage.setItem('gridHeroCount', gridHeroCount);
        gridHeroesElement.innerText = 'Total GridHeroes: ' + gridHeroCount;
        if (gridHeroCount % 100 === 0) {
            alert('Congratulations! You are the ' + gridHeroCount + 'th GridHero to Humanity Grid!');
        }
    }
});