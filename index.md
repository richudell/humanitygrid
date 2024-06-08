![Humanity Grid](images/banner.png)

# Welcome to Humanity Grid

## Our Vision
Humanity Grid is a pioneering, community-driven platform designed to harness the power of distributed computing and artificial intelligence (AI) to tackle global challenges. By joining forces and leveraging the collective power of everyday devices worldwide, we aim to provide scalable, redundant, and secure solutions for complex problems that require immense computational resources.

<!-- Google Tag Manager -->
<script>
(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','G-LCK692PHM6');
</script>
<!-- End Google Tag Manager -->

<!-- Google Tag Manager (noscript) -->
<noscript>
  <iframe src="https://www.googletagmanager.com/ns.html?id=G-LCK692PHM6"
  height="0" width="0" style="display:none;visibility:hidden"></iframe>
</noscript>
<!-- End Google Tag Manager (noscript) -->

<!-- Consent Banner HTML and CSS -->
<div class="consent-banner" id="consent-banner" role="dialog" aria-live="polite">
  <p>We use cookies to ensure you get the best experience on our website. By continuing to use this site, you consent to our use of cookies.</p>
  <button onclick="acceptConsent()">Accept</button>
</div>

<style>
  body {
    font-family: 'Roboto', sans-serif;
    color: #333;
    background-color: #f4f4f9;
    margin: 0;
    padding: 0;
    display: flex;
    flex-direction: column;
    min-height: 100vh;
  }
  header {
    background: linear-gradient(90deg, #1c92d2, #f2fcfe);
    color: white;
    padding: 2em 0;
    text-align: center;
  }
  header img {
    max-width: 100%;
    height: auto;
  }
  h1 {
    font-size: 2.5em;
    margin: 0.5em 0;
  }
  h2 {
    font-size: 2em;
    color: #1c92d2;
  }
  p {
    font-size: 1.2em;
    line-height: 1.6;
  }
  a {
    color: #1c92d2;
  }
  a:focus, button:focus {
    outline: 3px solid #1c92d2;
  }
  .highlight {
    background-color: #004080;
    color: white;
    padding: 2em;
    text-align: center;
    margin: 2em 0;
    border-radius: 8px;
  }
  .highlight h2, .highlight p {
    color: #ffffff;
  }
  .consent-banner {
    position: fixed;
    bottom: 0;
    width: 100%;
    background-color: #333;
    color: white;
    text-align: center;
    padding: 1em;
    z-index: 1000;
    display: none;
  }
  .consent-banner button {
    background-color: #4CAF50;
    color: white;
    border: none;
    padding: 10px 20px;
    cursor: pointer;
    margin-left: 10px;
  }
  .content {
    flex: 1;
    padding: 20px;
  }
  footer {
    background: #1c92d2;
    color: white;
    text-align: center;
    padding: 1em 0;
    width: 100%;
  }
</style>

<header>
  <img src="images/banner.png" alt="Humanity Grid Banner">
  <h1>Welcome to Humanity Grid</h1>
</header>

<!-- GridHero Counter and Consent Banner JavaScript -->
<script>
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
</script>
<p id="gridHeroCount" style="text-align: center; font-size: 0.9em; color: gray;">Loading GridHero count...</p>

<div class="content">
<h2>How It Works</h2>
<h3>Distributed Network</h3>
<p>Devices such as smartphones, tablets, and computers join our global network, sharing their idle processing power. Together, we form a powerful, decentralized computing grid capable of tackling a wide range of tasks.</p>

<h3>Redundant Data Storage</h3>
<p>Inspired by RAID 5, we store data with redundancy across multiple devices to ensure reliability and fault tolerance. This approach enhances data security and availability, making our network resilient to individual device failures.</p>

<h3>Web 3.0 Integration</h3>
<p>Utilizing blockchain technology and smart contracts, Humanity Grid manages and verifies transactions, ensuring transparency and security within the network. This integration supports a decentralized and trustless environment, where participants can confidently contribute and collaborate.</p>

<h2>Key Features</h2>
<ul>
  <li><strong>Accessibility:</strong> Everyone is welcome to participate, regardless of technical background or resources. Your device’s idle processing power can make a difference.</li>
  <li><strong>Community-Driven:</strong> Our platform is open-source and collaborative, inviting innovation from developers, researchers, and tech enthusiasts. Your input is crucial for our continuous improvement and expansion.</li>
  <li><strong>Scalable Solutions:</strong> Beyond initial tasks like prime number calculations, our platform can expand to address various scientific, medical, and environmental challenges.</li>
  <li><strong>Incentives:</strong> Participants earn tokens for their contributions, promoting active involvement and rewarding participation.</li>
</ul>

<h2>Join the Movement</h2>
<h3>Shape the Future</h3>
<p>This is a ground-floor opportunity to be part of something transformative. Here’s how you can get involved:</p>

<h3>Contribute Ideas and Feedback</h3>
<p>Your input is invaluable in shaping the future of Humanity Grid. Here’s how you can contribute:</p>
<ul>
  <li><strong>Join Our Forum:</strong> Coming soon!!</li>
  <li><strong>Submit Feedback:</strong> <a href="feedback.md">Feedback Form</a></li>
  <li><strong>Participate in Discussions:</strong> Engage with us on our social media channels.</li>
</ul>

<h3>Spread the Word</h3>
<p>Help us grow by sharing Humanity Grid with your network:</p>
<ul>
  <li><strong>Share on Social Media:</strong> Use the hashtag #HumanityGrid and #GridHeroes and tag us in your posts.</li>
  <li><strong>Invite Friends:</strong> Send them to our website to learn more and join.</li>
</ul>

<h2>Conclusion</h2>
<p>Humanity Grid represents a novel approach to distributed computing, enabling a decentralized, secure, and collaborative environment to solve some of the world’s most pressing challenges. Together, we can build a better future through the power of collective computing.</p>

<div class="highlight">
  <h2>HumanityGrid</h2>
  <p>HumanityGrid is a community-driven platform leveraging distributed computing and AI to solve global challenges.</p>
</div>
</div>

---

<h2>Important Dates</h2>
<ul>
  <li><strong>Birthday of Humanity Grid:</strong> 11:11 AM, June 7, 2024</li>
</ul>

---

<footer>
  <p>&copy; 2024 Humanity Grid. All rights reserved.</p>
</footer>