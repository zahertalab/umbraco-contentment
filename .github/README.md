<img src="../docs/assets/img/logo.png" alt="Contentment for Umbraco logo" title="A state of Umbraco happiness." height="130" align="right">

## Contentment for Umbraco

> contentment /kənˈtɛntm(ə)nt/ - a state of happiness and satisfaction

### What is it?

This is a collection of Umbraco components that I have developed for use on my own **Umbraco** implementation projects.

Some components may be innovative, others may be a reimagining of existing components, property-editors, features and other community packages.


#### Why should I use it?

I'm sharing my code with the world. It is your choice (and responsibility) whether you would like to use it.
No pressure or marketing spin from me.


#### What's on offer?

Let's take a look inside...

##### Property Editors

- [Bytes](../docs/editors/bytes.md) - a read-only label to display file sizes in relative bytes.
- [Code Editor](../docs/editors/code-editor.md) - a code snippet editor, _(using the ACE library that is bundled with Umbraco)._
- [Content Blocks](../docs/editors/content-blocks.md) - a block editor, configurable using element types.
- [Data List](../docs/editors/data-list.md) - an editor that combines a custom data source with a custom list editor.
- [Icon Picker](../docs/editors/icon-picker.md) - an editor to select an icon (from the Umbraco icon library).
- [Notes](../docs/editors/notes.md) - a read-only label to display rich-text instructional messages for content editors.
- [Number Input](../docs/editors/number-input.md) - a numeric editor, with sizing configurations.
- [Render Macro](../docs/editors/render-macro.md) - a read-only label dynamically generated from an Umbraco Macro.
- [Templated Label](../docs/editors/templated-label.md) - a display label, ideal for showing data from 3rd-party systems.
- [Textbox List](../docs/editors/textbox-list.md) - a multi-textstring editor, adds a textbox for each item in a custom data source.
- [Text Input](../docs/editors/text-input.md) - a textstring editor, configurable with HTML5 options.

#### Telemetry

Information about the [telemetry feature](../docs/telemetry.md).

#### Releases

Downloads are available on the [releases page](https://github.com/leekelleher/umbraco-contentment/releases).

#### Installation

_**Please note...**_

- v3.x has been developed against **Umbraco v8.17.0** and **Umbraco v9.0.0** and will support those versions and above.
- v2.x has been developed against **Umbraco v8.14.0** and it will still work on current Umbraco v8.x releases.
- v1.x has been developed against **Umbraco v8.6.1**, it will still work on current Umbraco v8.x releases.

With Contentment v3.x on Umbraco v9.0 (.NET 5), you can only install a package from the [NuGet package repository](https://www.nuget.org/packages/Our.Umbraco.Community.Contentment). For Umbraco v8.x, the package can still be installed from either [Our Umbraco](https://our.umbraco.com/packages/backoffice-extensions/contentment/) or NuGet package repositories.

##### NuGet package repository

To [install from NuGet](https://www.nuget.org/packages/Our.Umbraco.Community.Contentment), you can run the following command from within Visual Studio:

    PM> Install-Package Our.Umbraco.Community.Contentment

...or if you are using the `dotnet` command line interface?

    dotnet add package Our.Umbraco.Community.Contentment

##### Our Umbraco package repository

If you are using Umbraco v8.x, and prefer to install Contentment from the backoffice, the package can be downloaded from the Our Umbraco package repository:

> <https://our.umbraco.com/packages/backoffice-extensions/contentment/>


#### Demo website

[A demo website is available for testing purposes.](../src/Umbraco.Cms.9.0.0/README.md) _(Please note, you will need to clone the repository and run locally.)_


### Documentation

[Documentation for each of the components - with screenshots, use-cases and code examples](../docs/) - can be found in the `/docs` folder.

Please note, you may find other components within Contentment that have not yet been documented.<br>
_Let's call those "life's little surprises"._


#### Known issues

- **Data List**
  - When using the Umbraco Content data source with an XPath query, inside a Nested Content editor, it will not be able to identify the contextual containing node ID. e.g. your XPath query will not work. [See #30 for details.](https://github.com/leekelleher/umbraco-contentment/issues/30)
  - When using the Umbraco Content data source with an XPath query that contains a `$` prefix parameter, the preview will not display the items. [See #120 for details.](https://github.com/leekelleher/umbraco-contentment/issues/120)
  - With Umbraco v9 (Contentment v3), SQL data source does not support querying SQL CE. [See #172 for details.](https://github.com/leekelleher/umbraco-contentment/issues/172)


### Roadmap

If you would like to know what is coming up in future releases, then take a look at the [roadmap](ROADMAP.md).


### Support

I've been doing open source for a long time. I have suffered my fair share of burnout and empathy fatigue.

I reserve the right to address bug reports or feature requests in my own time, or ignore them completely.

**Any feedback is welcome and appreciated.** But please keep in mind, I am not your personal support developer.

If you are really stuck, do remember that the Umbraco community is amongst the friendliest on our planet, learn to embrace it. 
Ask for help on the [Our Umbraco support forum](https://our.umbraco.com/), I am sure someone can help you there.


### Contributions, collaborations, rules of engagement

If you would like to contribute to this project, please start a discussion before spending time and energy on a pull request. Your time is precious too.

Please make sure that you read the [CONTRIBUTING](CONTRIBUTING.md) guidelines.

This project is governed by a [Code of Conduct](CODE_OF_CONDUCT.md). **Play nice or go home.** :v::heart::dove:

If you are unhappy with the project or documentation, please help to identify specific issues and work towards resolving them.
Otherwise you are completely free to not use this software, complain on your favourite social network, or go shout into the void.

Unacceptable behaviour towards myself (or contributors) may result in being blocked from accessing this repository.


### License

Copyright &copy; [Lee Kelleher](https://leekelleher.com).

All source code is licensed under the [Mozilla Public License](../LICENSE).

#### A note about licensing

Historically, I used the [MIT license](https://opensource.org/licenses/MIT) for my open-source projects, regretfully I no longer feel MIT reflects my spirit of encouraging open source collaboration.
The main difference with the [Mozilla Public License](https://opensource.org/licenses/MPL-2.0) is that if you make any modifications to the source code, then you **must** make those changes publicly available.

_More give, less take._

If you do not to intend to modify the source code, then you will still have the same freedoms as when using the MIT license.

For more information about the **Mozilla Public License**, please visit: <https://www.mozilla.org/en-US/MPL/2.0/FAQ/>


### Acknowledgements

#### Developers

- [Lee Kelleher](https://leekelleher.com) - ([GitHub](https://github.com/leekelleher), [Twitter](https://twitter.com/leekelleher))

<details>
<summary>Current development effort: <b>1145+ hours</b> (between 2019-03-13 to 2022-02-10)</summary>

_To give you an idea of how much human developer time/effort has been put into making this package._

</details>


#### Special thanks

- Thank you to [Umbrella](https://umbrellainc.co.uk) for facilitating the time and resource to help me initiate this project.


#### Logo

The package logo uses the [Happy](https://thenounproject.com/term/happy/375493/) (by [Nick Bluth](https://thenounproject.com/nickbluth/)) icon from the [Noun Project](https://thenounproject.com), licensed under [CC BY 3.0 US](https://creativecommons.org/licenses/by/3.0/us/).
