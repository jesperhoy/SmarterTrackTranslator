# SmarterTrack Translator

A Windows desktop tool for creating and updating translation files (for UI internationalization) for [SmarterTrack](https://www.smartertools.com/smartertrack).

![](screenshot.png)

## How to use?

First load in the English version (File menu / Open English) using the "en.xml" file from your SmarterTrack web-site. This gives you a table where the "ID" and "English" columns are filled in, and the "Translated" column is blank.
Next fill in the cells in the "Translated" column one by one. 
Finally save your work (File menu / Save Translation) and generate a new language translation file for upload to your SmarterTrack web-site (File menu / Save Combined).

The "Save Translation" function generates a file which only contains the entries that have been translated. Entries where the "Translated" column is blank are not saved. 

The "Save Combined" function generates a complete translation file which can be uploaded to your SmarterTrack web-site. For entries where the "Translated" column is blank, the English version is used instead.

You should always keep a separate "Save Translation" file version of your work.

When you want to continue your work later, or update a translation when SmarterTools releases a new version (with new translation items), you always first "Open English" (using the current "en.xml" version from your web-site), then "Open Translation". This will match up English and translated items based on the ID column.

## How to install

Make sure you have .NET Framework v. 4.8 installed / enabled on your computer.

Download and run SmarterTrackTranslator.exe from https://github.com/jesperhoy/SmarterTrackTranslator/releases

## Dependencies 

- .NET Framework v. 4.8

## Versioning

This project uses [Semantic Versioning](https://semver.org/).

## Contributions

Contributions are most welcome. No contribution is too big or too small.

Fork this repository, clone locally, make your updates, commit, push, create a pull request in GitHub...

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Acknowledgments

- Thanks to [SmarterTools](https://smartertools.com) for making SmarterTrack.