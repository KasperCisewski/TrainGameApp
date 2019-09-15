import styled from 'styled-components';

export const RankingWrapper = styled.div`
	height: 80vh;
	padding: 0 12px;
	display: flex;
	flex-direction: column;
	justify-content: center;
	align-items: center;
`;

export const Leaderboard = styled.div`
	display: flex;
	flex-direction: column;
	align-items: center;
	width: 70%;
	max-width: 400px;
	& > span {
		font-size: 32px;
	}
	& > div {
		width: 100%;
		display: flex;
		justify-content: space-between;
		height: 64px;
		font-size: 20px;
		margin: 8px 0;
		position: relative;
		& > div {
			width: 80%;
			display: flex;
			flex-direction: column;
			justify-content: center;
		}
		& > img {
			position: absolute;
			top: 50%;
			transform: translateY(-50%);
			right: 8px;
			width: 48px;
		}
		& > span {
			position: absolute;
			top: 50%;
			transform: translateY(-63%);
			right: 21px;
			color: ${props => props.theme.white};
		}
	}
`;
