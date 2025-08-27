<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Skills</title>
  <style>
    body {
      background: #0f172a;
      color: white;
      font-family: Arial, sans-serif;
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
      height: 100vh;
      margin: 0;
    }

    h2 {
      margin-bottom: 20px;
      font-size: 28px;
    }

    .skills, .learning, .tools {
      display: flex;
      gap: 25px;
      margin-bottom: 30px;
    }

    .skills img, .learning img, .tools img {
      width: 60px;
      height: 60px;
      transition: transform 0.3s;
    }

    .skills img:hover, .learning img:hover, .tools img:hover {
      transform: scale(1.2);
    }

    .section-title {
      font-size: 20px;
      margin-bottom: 10px;
      font-weight: bold;
      color: #38bdf8;
    }
  </style>
</head>
<body>
  <div>
    <div class="section-title">Languages I use</div>
    <div class="skills">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" alt="C#">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg" alt="HTML">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/css3/css3-original.svg" alt="CSS">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/javascript/javascript-original.svg" alt="JavaScript">
    </div>
  </div>

  <div>
    <div class="section-title">Learning</div>
    <div class="learning">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/java/java-original.svg" alt="Java">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-original.svg" alt=".NET">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original.svg" alt="MySQL">
    </div>
  </div>

  <div>
    <div class="section-title">Tools</div>
    <div class="tools">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg" alt="VS Code">
      <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" alt="Visual Studio">
    </div>
  </div>
</body>
</html>

