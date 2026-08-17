# Chrono Count 3

Chrono Count 3 is a Windows Forms application for creating and managing timestamps for upcoming events. It provides live countdowns, customizable formatting, color themes, and persistent local storage.

## Features

- Live countdowns for upcoming events
- Custom dates and times
- Custom event descriptions
- Paginated timestamp display
- Remove individual timestamps or completed events
- Customizable foreground, middle, and background colors
- Adjustable description, date, and countdown formats
- Dynamic form and font resizing
- Persistent data stored locally in `Data.csv`
- User settings stored in `UserSettings.json`
- Automatic sorting by nearest upcoming event

## Display Formats

Timestamp information can be displayed using four different length options:

- **None** — Hide the selected information
- **Short** — Compact display
- **Medium** — Balanced display
- **Long** — Detailed display

For example, countdowns can be displayed as:

```text
5d:12h
03h:42m
27m:15s
42s
```

Completed timestamps are shown as `Done` or `✓`, depending on the selected display format.

## Usage

### Creating a Timestamp

1. Open the **Create** window.
2. Enter a name for the event.
3. Enter the date and time.
4. Click **Create**.
5. The timestamp is added and automatically sorted by date.

### Removing Timestamps

Use the **Remove** window to:

- Remove a specific timestamp.
- Remove a timestamp from a selected page.
- Remove all completed timestamps.

### Settings

The settings menu allows you to customize:

- Items displayed per page
- Foreground, middle, and background colors
- Description length
- Date format
- Countdown format

Settings are saved automatically and applied after restarting the application.

## Data Storage

The application stores its data in the application directory:

```text
Data.csv
UserSettings.json
```

`Data.csv` contains saved timestamps, while `UserSettings.json` stores the user's display and color preferences.

## Requirements

- Windows
- .NET
- C#
- Windows Forms

## Project Structure

```text
Chrono Count 3
├── Forms/
│   ├── HomeForm
│   ├── CreateForm
│   ├── RemoveForm
│   └── SettingsForm
├── CodeFiles/
│   ├── Settings/
│   ├── TimeStamp/
│   └── SizerTools/
└── Data.csv
```

## Purpose

Chrono Count 3 is designed as a lightweight desktop tool for keeping track of events, deadlines, appointments, and other future timestamps without relying on an external service.
