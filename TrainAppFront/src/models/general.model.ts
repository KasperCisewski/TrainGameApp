const generalModel = {
	state: {
		nickname: ''
	},
	reducers: {
		changeNickname(state: any, payload: any) {
			return {
				...state,
				nickname: payload
			}
		}
	}
};

export default generalModel;