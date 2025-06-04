# 📡 Devly.API – Fake Backend for Contact & Testimonials

This is a **simple .NET Core 8 Web API** backend that powers:

- `/api/contact` → receives contact form submissions, sends email via SMTP
- `/api/testimonials` → returns fake client testimonials

This API is meant to simulate a real-world backend for the [Devly Landing Page](../README.md) frontend.

---

## 🚀 Getting Started

### 🔧 Prerequisites

- .NET SDK 8.0 or later
- SMTP credentials (Gmail, SendGrid, etc.)

---

### ▶️ Run the API locally

```bash
cd Devly.API
dotnet run
API will be available at:

http://localhost:5000

https://localhost:5001

