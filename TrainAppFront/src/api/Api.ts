import axios from 'axios';

const axiosInstance = axios.create({
	baseURL: 'https://trainquiz-backend-hackyeah.azurewebsites.net/api/',
	timeout: 1000
});

// THIS IS A FUCKING HELPER FUNCTION TO MOCK RESPONSE TIME
export const MOCK_fakeFetch = (data: any) => new Promise(resolve => setTimeout(() => resolve(data), 1000 + (Math.random() * 1500)));

export default axiosInstance;