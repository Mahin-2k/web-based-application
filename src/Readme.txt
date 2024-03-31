How To run projects in docker?

1. cd to your src folder ----------------------------------------------  :  cd C:\Users\muham.MUHAMMAD\Desktop\aspnetb8-team3\src> 

2. create volume :  docker volume create --driver local --opt type=none --opt device=D:\volumes\api --opt o=bind my-api-volume
	            docker volume create --driver local --opt type=none --opt device=D:\volumes\web --opt o=bind my-web-volume
	            docker volume create --driver local --opt type=none --opt device=D:\volumes\worker --opt o=bind my-worker-volume

3. MOST IMPORTANT uncomment this from program.cs of Web, Api ----------  :  builder.WebHost.UseUrls("http://*:80"); 

4. docker-compose up -d

5. docker-compose down  
