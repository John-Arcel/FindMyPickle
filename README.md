# FindMyPickleTournamemts - Pickleball Tournament Management Platform

A Blazor web application built with Tailwind CSS for browsing, filtering, and registering for competitive pickleball events. Designed with a clean dashboard interface, this app allows players to find tournaments worldwide, filter by skill ratings, register via modal popups, and manage existing entries with real-time UI state updates.

---

## Features

- **Worldwide Tournament Discovery**: Browse sanctioned and unsanctioned tournaments with real-time participant counts, dates, venue locations, and entry fees.
- **Recommended Events Carousel**: Horizontal scrolling section highlighting local and regional events with custom event banner styling.
- **Instant Search & Filtering**:
  - Full-text search matching tournament title, city, or host country.
  - DUPR skill bracket filter (DUPR 3.0 up to 5.0+ Pro).
  - One-click toggle filter for **Closing Soon** events.
- **Dual Display Modes**: Toggle between interactive responsive card grids and a structured table view.
- **Animated Registration Modal**:
  - Modal with backdrop blur and zoom transitions.
  - Division selection (Singles, Doubles, Mixed).
  - Conditional partner input field that dynamically appears when doubles divisions are selected.
  - Instant state reflection (status changes to `Registered`, participant count increments, and entry button changes to `Manage Entry`).
- **Manage & Withdraw Entry Modal**: Review registered tournament details with an option to withdraw entry and free up spots.

---

## Tech Stack

- **Framework**: [.NET 8 / Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) (Razor Components)
- **Styling**: [Tailwind CSS](https://tailwindcss.com/)
- **Language**: C# 12
- **Data Layer**: In-Memory POCO Models & Seed Collections (No external database dependency required)

