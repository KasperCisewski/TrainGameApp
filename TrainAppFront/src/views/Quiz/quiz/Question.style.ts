import styled from 'styled-components';

export const QuestionWrapper = styled.div`
	& > span {
		font-size: 32px;
	}
	& > div {
		margin-top: 32px;
		display: flex;
		flex-wrap: wrap;
		justify-content: space-between;
		& > div {
			width: 45%;
			height: 64px;
			background: violet;
			display: flex;
			align-items: center;
			justify-content: center;
			margin-bottom: 16px;
			border-radius: 2px;
			box-shadow: 2px 2px 1px darkviolet;
			transition: transform .125s;
			font-size: 18px;
			text-align: center;
			&:hover {
				transform: scale(1.05);
			}
		}
	}
`;