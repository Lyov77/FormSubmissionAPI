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
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background: linear-gradient(135deg, #6e7dff, #a0b7ff);
  margin: 0;
  padding: 0;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  height: 100vh;
}

/* Title styling */
.app-title {
  font-size: 3rem;
  color: #fff;
  margin-bottom: 20px;
  font-weight: 600;
}

/* Navigation bar styling */
.navbar {
  display: flex;
  gap: 30px;
  justify-content: center;
  margin-bottom: 30px;
}

.nav-link {
  font-size: 1.2rem;
  color: #fff;
  text-decoration: none;
  padding: 10px 20px;
  background-color: rgba(255, 255, 255, 0.2);
  border-radius: 25px;
  transition: background-color 0.3s, transform 0.2s;
}

/* Hover effects for nav links */
.nav-link:hover {
  background-color: rgba(255, 255, 255, 0.4);
  transform: translateY(-5px);
}

/* Styling for the form container */
.form-container {
  max-width: 600px;
  width: 100%;
  background-color: rgba(255, 255, 255, 0.9);
  padding: 40px;
  border-radius: 15px;
  box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
}

form {
  display: flex;
  flex-direction: column;
}

label {
  margin-bottom: 20px;
  font-size: 1.1rem;
}

input, select {
  padding: 10px;
  font-size: 1rem;
  border: 1px solid #ccc;
  border-radius: 5px;
  margin-top: 5px;
}

button {
  background-color: #6e7dff;
  color: #fff;
  font-size: 1.2rem;
  padding: 12px 20px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  margin-top: 20px;
  transition: background-color 0.3s, transform 0.2s;
}

button:hover {
  background-color: #4e59cc;
  transform: translateY(-5px);
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
    font-size: 2.5rem;
  }
}
</style>