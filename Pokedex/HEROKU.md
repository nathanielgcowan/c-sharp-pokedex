# .NET Core on Heroku

This app is ready for Heroku deployment using a custom buildpack.

## Steps

1. Install the Heroku CLI and log in.
2. Create a new Heroku app:
   ```sh
   heroku create --buildpack https://github.com/jincod/dotnetcore-buildpack.git
   ```
3. Push your code:
   ```sh
   git push heroku main
   ```
4. Open your app:
   ```sh
   heroku open
   ```

## Notes

- The Procfile and Program.cs are configured for Heroku's $PORT.
- Make sure your main branch is up to date.
- Replace placeholder images in wwwroot/images as needed.
