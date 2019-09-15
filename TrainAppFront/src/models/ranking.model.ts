import {getGlobalRankingR} from "../api/ranking.api";

interface positionI {
	id: number
	username: string
	points: number
	position: number
}

interface modelI {
	leaderboard: []
	me: null | positionI
}

const rankingModel = {
	state: {
		leaderboard: [],
		me: null
	},
	reducers: {
		onGetGlobalRanking(state: any, payload: any): modelI {
			return {
				...state,
				leaderboard: payload.leaderboard,
				me: payload.me
			}
		}
	},
	effects: {
		// @ts-ignore
		async getGlobalRanking() {
			const data = await getGlobalRankingR();

			// @ts-ignore
			return this.onGetGlobalRanking(data.data);
		}
	}
};

export default rankingModel;