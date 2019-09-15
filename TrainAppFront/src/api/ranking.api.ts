import Api, { MOCK_fakeFetch } from './Api';

export const getGlobalRankingR = () => MOCK_fakeFetch({
	data: {
		leaderboard: [
			{
				id: 1,
				username: 'User 1',
				points: 987560,
				position: 1
			},
			{
				id: 2,
				username: 'User 2',
				points: 78329,
				position: 2

			},
			{
				id: 3,
				username: 'User 3',
				points: 2199,
				position: 3

			}
		],
		me: {
			id: 98,
			username: 'ME',
			points: 1,
			position: 13
		}
	}
});