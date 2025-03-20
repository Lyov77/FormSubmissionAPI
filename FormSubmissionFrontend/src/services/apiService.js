// src/services/apiService.js
import axios from 'axios';

const BASE_URL = 'http://localhost:7050/api/forms/list'; // Update with your API URL

export const getSubmissions = async () => {
  try {
    const response = await axios.get(`${BASE_URL}/list`);
    return response.data;
  } catch (error) {
    console.error('Failed to fetch submissions:', error);
    throw error;
  }
};
