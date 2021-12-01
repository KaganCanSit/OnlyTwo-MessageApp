<div class="header">
  <h1> OnlyTwo-MessageApp </h1>
  <p>Project created for Software Testing course using socket programming and encryption algorithms together with C# language.</p>
</div>

<div class="info">
  <h2> Project Requirements </h2>
  <ol>
    <li>The text written by Single User will be encrypted with <b>SHA 256</b> or <b>SPN</b> and the user will see the encrypted text.</li>
    <li>With the Socket Program, your own encrypted message will be made from the user of the same user message and the user will be able to see the user password with the key (password) containing the password of the other user's message.</li>
    <li>The program will also be able to send other files (such as TXT, DAT or GIF) to the other party, but while sending (the file will be reduced in size after it is encrypted with a compression algorithm you will write or use ready-made).</li>
  </ol>
  <p>
      In addition;
      Software Specifications will be prepared.<br>
      Test Documents will be prepared with Test Cases.<br>
      Black Box and White Box tests will be done.<br>
      Souce Monitor and Github Control<br>
      Additional tool will be used for Design and Visuality.<br>
      ! All of these contents are available in files in the repo.
  </p>
</div>
<hr>
<div class="infoEncryption">
  <div class="images">
    <img src="https://github.com/KaganCanSit/OnlyTwo-MessageApp/blob/main/ProjectFiles/01_ProjectInfo/SHA256%20.png" width="400px" height="600px"></img>
    <img src="https://github.com/KaganCanSit/OnlyTwo-MessageApp/blob/main/ProjectFiles/01_ProjectInfo/SPN.png"  width="400px" height="600px"></img>
  </div>
  <h2>What Is SHA256 Encryption?</h2>
  <p> 
  SHA -256 (Secure Hash Algorithm) is an algorithm designed to be used in the Digital Signature Standard (DSA) developed by the National Security Agency. It is the encryption system with the highest security in the SHA-2 hash algorithm set. The SHA-256 feature is to convert data to standard size 32 byte -64 hexadecimal hash values.
  </p>
  <p>For more information and steps, you can refer to the "03- BlockChain Encrypiton Info" link in the resources section (below).</p> 

  <h2>What Is SPN-16 Encryption?</h2>
  <p>
  Spn encryption starts with a key and text as seen in the picture above. First, the key and text that we have imported are converted to ASCII numbers. Then all the text is "XOR" with the key as 0's and 1's. The resulting 0 1 ASCII string is forwarded. If the other person has the key, he/she performs the decrypte operation.
  </p>
</div>
<hr>
<div class="sources">
  <h2>Utilized Resources</h2>
    <a href="https://tr.wikipedia.org/wiki/ASCII">01- ASCII Table</a><br>
    <a href="https://www.rapidtables.com/convert/number/binary-to-ascii.html">02- Binary Convert- Check</a><br>
    <a href="https://www.serkanduran.com.tr/blockchain/blockchain-sifreleme-nasil-calisir/">03- BlockChain Encrypiton Info</a><br>
    <a href="https://akademiksunum.com/index.jsp?modul=document&folder=1773482bfc1501276f22c3254c4559626eaa45e4">04-SPN Encryption Info</a><br>
    <a href="https://www.youtube.com/watch?v=vtI6Wd7DogQ">05-SHA Youtube Videon</a><br>
    <a href="https://www.fluxbytes.com/csharp/convert-string-to-binary-and-binary-to-string-in-c/">06-Convert Binary/String</a><br>
    <a href="https://social.msdn.microsoft.com/Forums/tr-TR/003e8603-9163-4a0f-b4f2-c0f8e08f54f3/c-string-de-istenilen-karakteri-deitirme?forum=csharptr">07-Chracter Operation</a><br>
    <a href="https://www.youtube.com/watch?v=EzkvHj9s_Ys">08-MultiChat Socket Programming</a><br>
    <a href="http://www.yazilimmutfagi.com/index.php/2011/01/07/csharp-system-compression-dosya-sikistirma/">09-System Compression</a><br>
    <a href="https://www.youtube.com/watch?v=CFfjZfkciQQ">10-File Encrypt Decrypte</a><br>
    <a href="https://www.bilisimkonulari.com/c-textboxa-girilen-karakterleri-sayma-ve-sinirlama.html">11-Text Box Limitation</a><br>
    <a href="https://docs.microsoft.com/tr-tr/dotnet/standard/io/how-to-compress-and-extract-files">12-File Operation</a><br>
    <a href="https://www.youtube.com/watch?v=A-vShsIelvk">13-Zip File Operation</a><br>
    <a href="https://docs.microsoft.com/tr-tr/dotnet/api/system.net.sockets.socket.sendfile?view=net-6.0">14-Socket Info</a><br>
    <a href="https://www.codeproject.com/Questions/1090382/Tcp-IP-file-transfer-in-NET-using-socket-programmi">15-TSocket Info - 2</a><br>
    <a href="https://www.c-sharpcorner.com/uploadfile/0a7dc8/file-transfer-program-using-C-Sharp-net-windows-application/">15-TSocket Info - 3</a><br>
</div>
