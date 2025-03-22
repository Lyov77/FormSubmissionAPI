<template>
  <div id="app">
    <h1 class="app-title">Form Submission App</h1>

    <!-- Navigation links -->
    <nav class="navbar">
      <router-link to="/" class="nav-link">
        Submit Form
      </router-link>
      <router-link to="/submissions" class="nav-link">
        View Submissions
      </router-link>
    </nav>

    <!-- The content rendered based on the current route -->
    <router-view />
  </div>
</template>

<script setup>
import FormComponent from './components/FormComponent.vue';
</script>

<style scoped>
/* General styles for the body and background */
body {
  font-family: 'Helvetica Neue', Arial, sans-serif;
  background: linear-gradient(135deg, #6c7fff, #a8c1ff);
  margin: 0;
  padding: 0;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  height: 100vh;
  color: #444;
}

/* Title styling */
.app-title {
  font-size: 3.5rem;
  color: #1f2d3d;
  margin-bottom: 30px;
  font-weight: 700;
  text-align: center;
  letter-spacing: 1.5px;
}

/* Navbar Styling */
.navbar {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #333; /* Darker and professional navbar color */
  padding: 15px 20px;
  border-radius: 8px; /* Smooth rounded edges */
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); /* Light shadow for depth */
}

.nav-link {
  font-size: 1.2rem;
  color: #fff;
  text-decoration: none;
  margin: 0 15px; /* Adds some spacing between links */
  padding: 10px 15px;
  border-radius: 5px; /* Rounded buttons */
  font-weight: 500; /* Slightly bolder for professional feel */
  transition: background-color 0.3s ease, transform 0.2s ease;
}

.nav-link:hover {
  background-color: #0066cc; /* Subtle blue hover effect */
  transform: scale(1.05); /* Slightly enlarges on hover for modern effect */
}

.nav-link:active {
  background-color: #0057b7; /* Darker shade on active */
}


/* Styling for the form container */
.form-container {
  max-width: 700px;
  width: 100%;
  background-color: rgba(255, 255, 255, 0.9);
  padding: 40px;
  border-radius: 15px;
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.1);
}

/* Responsive Design */
@media (max-width: 768px) {
  .form-container {
    padding: 30px;
  }

  .nav-link {
    font-size: 1rem;
    padding: 8px 15px;
  }

  .app-title {
    font-size: 2.8rem;
  }
}
</style>
