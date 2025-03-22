<template>
    <div class="form-list-container">
      <h2>Submitted Forms</h2>
  
      <div v-if="submissions.length === 0" class="no-submissions">No submissions yet.</div>
  
      <ul v-else>
        <li v-for="submission in submissions" :key="submission.id" class="submission-item">
          <div class="submission-header">
            <h3 class="form-name">{{ submission.formName }}</h3>
            <p class="submitted-at">{{ new Date(submission.submittedAt).toLocaleString() }}</p>
          </div>
          <ul class="field-list">
            <li v-for="(value, key) in submission.fields" :key="key" class="field-item">
              <strong>{{ key }}:</strong> <span class="field-value">{{ value }}</span>
            </li>
          </ul>
        </li>
      </ul>
    </div>
  </template>
  
  <script setup>
  import { ref, onMounted } from 'vue';
  import axios from 'axios';
  
  const submissions = ref([]);
  
  const fetchSubmissions = async () => {
    try {
      console.log('Fetching submissions...');
      const response = await axios.get('https://localhost:7050/api/forms/list');
      submissions.value = response.data;
      console.log('Fetched submissions:', submissions.value);
    } catch (error) {
      console.error(error);
    }
  };
  
  onMounted(fetchSubmissions);
  </script>
  
  <style scoped>
  .form-list-container {
    max-width: 900px;
    margin: 0 auto 20px;
    padding: 20px;
    background-color: #f9f9f9;
    border-radius: 8px;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    font-family: Arial, sans-serif;
  }
  
  h2 {
    text-align: center;
    color: #333;
    font-size: 24px;
    margin-bottom: 20px;
  }
  
  .no-submissions {
    text-align: center;
    color: #888;
    font-style: italic;
  }
  
  ul {
    list-style-type: none;
    padding: 0;
  }
  
  .submission-item {
    background-color: #ffffff;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.05);
    margin-bottom: 20px;
    transition: transform 0.3s, box-shadow 0.3s;
  }
  
  .submission-item:hover {
    transform: translateY(-5px);
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.1);
  }
  
  .submission-header {
    margin-bottom: 15px;
  }
  
  .form-name {
    font-size: 1.5rem;
    color: #333;
    font-weight: 600;
  }
  
  .submitted-at {
    color: #777;
    font-size: 0.9rem;
    font-style: italic;
  }
  
  .field-list {
    margin-top: 15px;
    padding-left: 20px;
  }
  
  .field-item {
    margin-bottom: 10px;
    color: #555;
    font-size: 1rem;
  }
  
  .field-item strong {
    color: #333;
  }
  
  .field-value {
    color: #0077cc; /* Add color to the field values for better contrast */
  }
  
  @media (max-width: 768px) {
    .form-list-container {
      padding: 15px;
    }
  
    .form-name {
      font-size: 1.3rem;
    }
  
    .field-item {
      font-size: 0.95rem;
    }
  
    .submission-header {
      margin-bottom: 10px;
    }
  }
  </style>
  