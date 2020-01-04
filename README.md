# SmarterTrack Translator

A Windows desktop tool for creating and updating translation files (for UI internationalization) for [SmarterTrack](https://www.smartertools.com/smartertrack).

![](screenshot.png)

## How to use?

- Make sure your Windows computer has .NET Framework 4.8 installed.
- Download and run "SmarterTrackTranslator.exe" from <https://github.com/jesperhoy/SmarterTrackTranslator/releases>

To make a new translation:

- From the "File" menu, select "Open English...", and pick "...path-to-SmarterTrack-website\App_Data\Translations\en.xml"
- Enter values in the "Translated" column (double click - or select cell and start typing).
- From the "File" menu, select "Save Translation as..." (will save only translated records).
- From the "File" menu, select "Save Combined as..." (will save translated records and fill in blanks with English records).
- Upload the "combined" file to your web-server ("...path-to-SmarterTrack-website\App_Data\Translations\language-code.xml")

To edit/update a translation:

- From the "File" menu, select "Open English...", and pick "...path-to-SmarterTrack-website\App_Data\Translations\en.xml"
- From the "File" menu, select "Open Translation...".


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